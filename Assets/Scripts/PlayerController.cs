using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace First_2D_Game
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        public float ForceJump = 5; // req 5
        public float SpeedWalk = 3; // req 3
        
        
        public bool IsKeyBlue = false; // Подобран ли ключ
        private int _jumpQuantity = 0; // считает колличетво прыжков
        
        
        private Rigidbody2D _rigid;
        private SpriteRenderer _spriteRenderer;
        private Animator _animator;

        

        private void Awake()
        {
            _rigid = GetComponent<Rigidbody2D>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            
            _animator.SetFloat("Speed", Mathf.Abs(h)*1.5f);
            if (h < 0)
            {
                _spriteRenderer.flipX = true;
            }
            if (h > 0)
            {
                _spriteRenderer.flipX = false;
            }
            
            _rigid.velocity = new Vector2(h * SpeedWalk, _rigid.velocity.y);

            if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W))
            {
                _jumpQuantity++;
                if (_jumpQuantity < 3)
                {
                    _animator.SetTrigger("Jump");
                    _rigid.velocity = new Vector2(_rigid.velocity.x, 0); 
                    _rigid.AddForce(Vector2.up * ForceJump, ForceMode2D.Impulse);
                }
            }
        }

        public void RestartLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void Death()
        {
            
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            _animator.SetBool("isGround", true);
            _jumpQuantity = 0;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            _animator.SetBool("isGround", false);
        }
    }
}