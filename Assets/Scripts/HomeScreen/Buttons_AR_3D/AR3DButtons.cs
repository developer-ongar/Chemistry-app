using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class AR3DButtons : MonoBehaviour
    {
        [SerializeField] private Button _aRButtonPressed;
        [SerializeField] private Button _button3DPressed;
        [SerializeField] private Button _buttonAIPressed;

        public void ARButtonPressed()
        {
            SceneManager.LoadScene(3);
        }

        public void Button3DPressed()
        {
            SceneManager.LoadScene(2);
        }

        public void ButtonAIPressed()
        {
            SceneManager.LoadScene(22);
        }
    }
}

