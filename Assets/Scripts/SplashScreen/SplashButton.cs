using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar

{
    public class SplashButton : MonoBehaviour
    {
        [SerializeField] private Button _splashButtonPressed;

        public void splashButtonPressed()
        {
            SceneManager.LoadScene(1);
        }
    }
}

