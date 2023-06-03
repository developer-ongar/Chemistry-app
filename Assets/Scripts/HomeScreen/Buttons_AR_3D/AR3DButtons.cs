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

        public void ARButtonPressed()
        {
            SceneManager.LoadScene(3);
        }

        public void Button3DPressed()
        {
            SceneManager.LoadScene(2);
        }
    }
}

