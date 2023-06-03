using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class EthanolBack : MonoBehaviour
    {
        [SerializeField] private Button _ethanolBackButton;

        public void EthanolBackButton()
        {
            SceneManager.LoadScene(2);
        }

    }

}

