using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    public BeaconController BeaconController;
    public GameObject activeBeacon;

    public enum GameState
    {
        Start,
        MainMenu,
        Map,
        BeaconDeployment,
        Combat
    }

    public static GameState ActiveGameState;

    private void Awake()
    {
        Instance = this;
    }
    

    public void SetGameState(GameState state)
    {
        ActiveGameState = state;
    }
}
