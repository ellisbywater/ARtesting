using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Screen Transition")]
public class ScreenTransiton : ScriptableObject
{
    [SerializeField]
    public string PreviousScreenName { get; set; }
    public string ActiveScreenName { get; set; }
    public GameObject PreviousScreen { get; set; }
    public GameObject ActiveScreen { get; set; }

    public ScreenTransiton(GameObject previous, GameObject active, string previousName, string activeName)
    {
        PreviousScreen = previous;
        ActiveScreen = active;
        PreviousScreenName = previousName;
        ActiveScreenName = activeName;
    }

    public void Transition()
    {
        PreviousScreen.SetActive(false);
        ActiveScreen.SetActive(true);
    }
}
