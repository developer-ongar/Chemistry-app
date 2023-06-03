using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class AllBackButton : MonoBehaviour
    {
        [SerializeField] private Button _all3DBackButton;

        public void All3DBackButton()
        {
            SceneManager.LoadScene(2);
        }
    }
}

