using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class BackARScene : MonoBehaviour
    {
        [SerializeField] private Button _backARSceneButton;

        public void BackARButton()
        {
            SceneManager.LoadScene(1);
        }
    }
}


