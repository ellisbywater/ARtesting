using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class UIManager : MonoBehaviour
{
    public GameController GameController;
    public List<GameObject> uiStates = new List<GameObject>();
    public GameObject userInterface;
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameController.ActiveGameState)
        {
            case GameController.GameState.BeaconDeployment:
               ActiveUISwitch("beacon");
                break;
            case GameController.GameState.Combat:
                ActiveUISwitch("combat");
                break;
            default:
                ActiveUISwitch("default");
                break;

        }
      
    }

    void ActiveUISwitch(string activeName)
    {
         for (int i = 0; i <= uiStates.Count; i++)
         {
             uiStates[i].SetActive(uiStates[i].name == activeName);
         };
    }
    
    
    
}
