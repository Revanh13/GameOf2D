using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace First_2D_Game
{
    public class CameraFollow : MonoBehaviour
    {
        private Transform _cam;
        public Transform Target;
        public float FollowSpeed = 1;

        private void Awake()
        {
            _cam = Camera.main.transform;
        }

        private void Update()
        {
            Follow();
        }

        private void Follow()
        {
            var _temp = new Vector3(
                Mathf.Lerp(_cam.position.x, Target.position.x, Time.deltaTime * FollowSpeed),
                Mathf.Lerp(_cam.position.y, Target.position.y, Time.deltaTime * FollowSpeed),
                _cam.position.z);
            _cam.position = _temp;
        }
    }
}