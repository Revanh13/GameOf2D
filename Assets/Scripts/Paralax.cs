using System;
using UnityEngine;

namespace First_2D_Game
{
    public class Paralax : MonoBehaviour
    {
        public Material Paralax_1;

        public float speedParalaxLayerBack_1 = 0.1f;
        

        private void OnGUI()
        {
            float h = Input.GetAxis("Horizontal");
            float offset_1 = h * Time.deltaTime * speedParalaxLayerBack_1;
            
            Paralax_1.mainTextureOffset += new Vector2(offset_1, 0);
        }

        private void OnDisable()
        {
            Paralax_1.mainTextureOffset = new Vector2(0, 0);
        }
    }
}    