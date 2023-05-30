using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Ongar
{
    public class WebViewScripts : MonoBehaviour
    {
        [SerializeField] private Button _splashButtonPressed;

        public void splashButtonPressed()
        {
            SceneManager.LoadScene(1);
        }
    }
}

