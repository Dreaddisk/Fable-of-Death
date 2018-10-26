using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    #region Variables
    [SerializeField] Text textComponent;
    #endregion

    #region UnityFunctions
    private void Start()
    {
        textComponent.text = ("You are into my domain");
    }
    #endregion
}// Main Class
