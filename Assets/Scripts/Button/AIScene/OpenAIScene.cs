using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class OpenAIScene : MonoBehaviour
    {
        [SerializeField] private Button _openAIButton;
        [SerializeField] private Button _BackAISceneButton;

        public void OpenAIButton()
        {
            SceneManager.LoadScene(23);
        }

        public void BackAISceneButton()
        {
            SceneManager.LoadScene(1);
        }
    }

}

