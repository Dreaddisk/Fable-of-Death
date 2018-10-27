using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
    #region Variables
   [TextArea(10,14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    #endregion


    public string GetStateStory()
    {

        return (storyText);
    }

    public State[] GetNextStates()
    {
        return (nextStates);
    }
}//  main class
