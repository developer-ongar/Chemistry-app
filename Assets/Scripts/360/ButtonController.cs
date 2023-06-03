using UnityEngine;
using UnityEngine.UI;

namespace Ongar
{
    public class ButtonController : MonoBehaviour
    {
        public Transform modelTransform;
        public float rotationSpeed = 100f;

        private bool isRotating = false;

        private void Update()
        {
            if (isRotating)
            {
                modelTransform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            }
        }

        public void ToggleRotation()
        {
            isRotating = !isRotating;

            if (!isRotating)
            {
                
                modelTransform.rotation = Quaternion.identity;
            }
        }
    }
}
