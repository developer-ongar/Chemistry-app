using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class EthaneBack : MonoBehaviour
    {
        [SerializeField] private Button _ethaneBackButton;

        public void EthaneBackButton()
        {
            SceneManager.LoadScene(2);
        }
    }
}


