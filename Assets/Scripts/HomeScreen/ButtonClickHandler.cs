using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ongar
{
    public class ButtonClickHandler : MonoBehaviour
    {
        public MoleculeDisplay moleculeDisplay; 

        private Button button;

        private void Start()
        {
            button = GetComponent<Button>();

            
            button.onClick.AddListener(moleculeDisplay.DisplayMoleculeStructure);
        }
    }
}


