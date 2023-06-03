using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ongar
{
    public class RotationController : MonoBehaviour
    {
        public float rotationSpeed = 100f; 

        private bool isRotating = false;

        private void Update()
        {
            if (isRotating)
            {
                
                transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            }
        }

        public void StartRotation()
        {
            isRotating = true;
        }

        public void StopRotation()
        {
            isRotating = false;
        }
    }
}


