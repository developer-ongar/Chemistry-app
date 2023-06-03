using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class Open3DButton : MonoBehaviour
    {
        [SerializeField] private Button _openBenzenePressed;
        [SerializeField] private Button _openButanePressed;
        [SerializeField] private Button _openEthanePressed;
        [SerializeField] private Button _openEthanolPressed;
        [SerializeField] private Button _openFullerenePressed;
        [SerializeField] private Button _openH2OPressed;
        [SerializeField] private Button _openHexanePressed;
        [SerializeField] private Button _openMethanePressed;
        [SerializeField] private Button _openPropanePressed;

        public void OpenBenzenePressed()
        {
            SceneManager.LoadScene(4);
        }

        public void OpenButanePressed()
        {
            SceneManager.LoadScene(5);
        }

        public void OpenEthanePressed()
        {
            SceneManager.LoadScene(6);
        }

        public void OpenEthanolPressed()
        {
            SceneManager.LoadScene(7);
        }

        public void OpenFullerenePressed()
        {
            SceneManager.LoadScene(8);
        }

        public void OpenH2OPressed()
        {
            SceneManager.LoadScene(9);
        }

        public void OpenHexanePressed()
        {
            SceneManager.LoadScene(10);
        }

        public void OpenMethanePressed()
        {
            SceneManager.LoadScene(11);
        }

        public void OpenPropanePressed()
        {
            SceneManager.LoadScene(12);
        }

    }
}

