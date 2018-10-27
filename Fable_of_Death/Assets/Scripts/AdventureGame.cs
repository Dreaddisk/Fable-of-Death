using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    #region Variables
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    int[] oddNumbers = { 1, 3, 5, 7, 9 };

    State state;
    #endregion

    #region UnityFunctions
    private void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(oddNumbers[3]);
    }
    #endregion
}// Main Class
