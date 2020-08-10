using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class UIManager : MonoBehaviour
{
    struct UIObject
    {
        public GraphicRaycaster uiRaycaster;
        public GameObject uiPanel;
    }
    [SerializeField] private GameObject uiPanel;

    [SerializeField] private Button placeBeaconButton;

    [SerializeField] private ARRaycastManager _raycastManager;

    [SerializeField] private GraphicRaycaster uiRaycaster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
