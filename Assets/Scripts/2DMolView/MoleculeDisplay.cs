using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Ongar
{
    public class MoleculeDisplay : MonoBehaviour
    {
        public RawImage rawImage;
        public InputField inputField;

        private string apiURL = "https://pubchem.ncbi.nlm.nih.gov/rest/pug/compound/name/";

        public void HandleButtonClick()
        {
            DisplayMoleculeStructure();
        }

        public void DisplayMoleculeStructure()
        {
            string moleculeName = inputField.text;
            StartCoroutine(FetchMoleculeStructure(moleculeName));
        }

        private IEnumerator FetchMoleculeStructure(string moleculeName)
        {
            string encodedCompoundName = WWW.EscapeURL(moleculeName);
            string requestURL = apiURL + encodedCompoundName + "/record/PNG";

            using (WWW www = new WWW(requestURL))
            {
                yield return www;

                if (string.IsNullOrEmpty(www.error))
                {
                    Texture2D texture = new Texture2D(2, 2);
                    www.LoadImageIntoTexture(texture);
                    rawImage.texture = texture;
                }
                else
                {
                    Debug.Log("Error fetching molecule structure: " + www.error);
                }
            }
        }
    }
}

