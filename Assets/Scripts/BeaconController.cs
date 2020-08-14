using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class BeaconController : MonoBehaviour
{
    public static BeaconController Instance;
    public GameController GameController;
    public GameObject beaconPrefab;
    public ARRaycastManager raycastManager;
    private Camera _playerCamera;

    [FormerlySerializedAs("_beaconSet")] public bool beaconSet = false;
    public GameObject activeBeacon {  private set;  get; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _playerCamera = Camera.main;
    }

    public void OnCreateBeaconButton()
    {
        Ray rayToCast = _playerCamera.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
        List<ARRaycastHit> hitPoints = new List<ARRaycastHit>();
        raycastManager.Raycast(rayToCast, hitPoints, TrackableType.Planes);
        
        if (hitPoints.Count > 0)
        {
            Pose pose = hitPoints[0].pose;
            /*transform.rotation = pose.rotation;
            transform.position = pose.position;*/

            if (!beaconSet) 
            {
                CreateBeacon(pose);
            }
            else
            {
                activeBeacon.transform.position = pose.position;
            }
        }
    }

    public void OnDeleteBeaconPressed()
    {
        DeleteBeacon();
    }

    private void CreateBeacon(Pose pose)
    {
        activeBeacon = Instantiate(beaconPrefab, pose.position, pose.rotation);
        Debug.Log("Active beacon is : ", activeBeacon);
        beaconSet = true;
        GameController.Instance.activeBeacon = activeBeacon;
    }

    private void DeleteBeacon()
    {
        Destroy(activeBeacon);
        beaconSet = false;
    }
    
}
