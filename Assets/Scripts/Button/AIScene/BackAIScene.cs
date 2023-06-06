using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class BackAIScene : MonoBehaviour
    {
        [SerializeField] private Button _backAIButton;

        public void BackAIButton()
        {
            SceneManager.LoadScene(22);
        }
    }
}

