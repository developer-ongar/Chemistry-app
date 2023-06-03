using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class BenzeneBack : MonoBehaviour
    {
        [SerializeField] private Button _benzeneBackButton;

        public void BenzeneBackButton()
        {
            SceneManager.LoadScene(2);
        }
    }

}


