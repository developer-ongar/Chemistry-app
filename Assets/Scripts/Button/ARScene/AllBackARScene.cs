using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class AllBackARScene : MonoBehaviour
    {
        [SerializeField] private Button _allARBackButton;

        public void AllARBackButton()
        {
            SceneManager.LoadScene(3);
        }
    }
}

