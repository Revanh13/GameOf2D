using System.Collections;
using UnityEngine;

namespace First_2D_Game
{
    public class TrapController : MonoBehaviour
    {
        [Range(1, 5)]
        public int Type = 1;
        private void OnCollisionEnter2D(Collision2D other)
        {
            // int _type = Random.Range(1, 2);
            if (Type == 1)
            {
                StartCoroutine(Trap_1());
            }

            if (Type == 2)
            {
                StartCoroutine(Trap_2());
            }

            if (Type == 3)
            {
                gameObject.SetActive(false);
            }
        }

        IEnumerator Trap_1()
        {
            yield return new WaitForSeconds(0.2f);
            gameObject.SetActive(false);
        }

        IEnumerator Trap_2()
        {
            yield return new WaitForSeconds(0.5f);
            gameObject.SetActive(false);
        }

        
    }
}