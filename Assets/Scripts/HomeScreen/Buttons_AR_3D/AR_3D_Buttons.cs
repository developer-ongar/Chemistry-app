using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class AR_3D_Buttons : MonoBehaviour
    {
        [SerializeField] private Button _buttonARPressed;
        [SerializeField] private Button _button3DPressed;

        public void buttonARPressed()
        {
            SceneManager.LoadScene(3);
        }

        public void button3DPressed()
        {
            SceneManager.LoadScene(2);
        }
    }

}