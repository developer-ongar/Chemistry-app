using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class OpenARSceneButton : MonoBehaviour
    {
        [SerializeField] private Button _benzeneOpenAR;
        [SerializeField] private Button _butaneOpenAR;
        [SerializeField] private Button _ethaneOpenAR;
        [SerializeField] private Button _ethanolOpenAR;
        [SerializeField] private Button _fullereneOpenAR;
        [SerializeField] private Button _h2oOpenAR;
        [SerializeField] private Button _hexaneOpenAR;
        [SerializeField] private Button _methaneOpenAR;
        [SerializeField] private Button _propaneOpenAR;

        public void BenzeneOpenAR()
        {
            SceneManager.LoadScene(13);
        }

        public void ButaneOpenAR()
        {
            SceneManager.LoadScene(14);
        }

        public void EthaneOpenAR()
        {
            SceneManager.LoadScene(15);
        }

        public void EthanolOpenAR()
        {
            SceneManager.LoadScene(16);
        }

        public void FullereneOpenAR()
        {
            SceneManager.LoadScene(17);
        }

        public void H2OOpenAR()
        {
            SceneManager.LoadScene(18);
        }

        public void HexaneOpenAR()
        {
            SceneManager.LoadScene(19);
        }

        public void MethaneOpenAR()
        {
            SceneManager.LoadScene(20);
        }

        public void PropaneOpenAR()
        {
            SceneManager.LoadScene(21);
        }

    }
}
