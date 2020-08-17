using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public GameObject StartingScreen;
    public GameObject beaconUI;

    [HideInInspector]
    public GameObject activeBeacon;

    public enum GameState
    {
        Default,
        MainMenu,
        Map,
        BeaconDeployment,
        Combat
    }

    public GameState ActiveGameState = GameState.Default;

    private void Awake()
    {
        Instance = this;
    }
    


    public void SetGameState(GameState state)
    {
        ActiveGameState = state;
    }

    public void ChangeScreen(GameObject previous, GameObject next)
    {
        previous.SetActive(false);
        next.SetActive(true);
    }

    public void StartGame()
    {
        ChangeScreen(StartingScreen, beaconUI);
        SetGameState(GameState.BeaconDeployment);
    }
    

}
