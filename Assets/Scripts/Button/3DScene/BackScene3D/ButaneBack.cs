using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class ButaneBack : MonoBehaviour
    {
        [SerializeField] private Button _butaneBackButton;

        public void ButaneBackButton()
        {
            SceneManager.LoadScene(2);
        }
    }
}

