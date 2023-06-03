using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Ongar
{
    public class Back3D : MonoBehaviour
    {
        [SerializeField] private Button _back3DScenePressed;

        public void Back3DScenePressed()
        {
            SceneManager.LoadScene(1);
        }
    }
}

