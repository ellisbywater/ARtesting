using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceBeacon : MonoBehaviour
{
    
    public GameObject beaconPrefab;
    public ARRaycastManager raycastManager;
    private Camera _playerCamera;

    private bool _beaconSet = false;
    private GameObject _activeBeacon;

    private void Start()
    {
        _playerCamera = Camera.main;
    }

    public void OnCreateBeaconButton()
    {
        Ray rayToCast = _playerCamera.ViewportPointToRay(new Vector2(.5f, .5f));
        List<ARRaycastHit> hitPoints = new List<ARRaycastHit>();
        raycastManager.Raycast(rayToCast, hitPoints, TrackableType.Planes);
        
        if (hitPoints.Count > 0)
        {
            Pose pose = hitPoints[0].pose;
            /*transform.rotation = pose.rotation;
            transform.position = pose.position;*/

            if (!_beaconSet) 
            {
                CreateBeacon(pose);
            }
            else
            {
                _activeBeacon.transform.position = pose.position;
            }
        }
    }

    public void OnDeleteBeaconPressed()
    {
        DeleteBeacon();
    }

    private void CreateBeacon(Pose pose)
    {
        _activeBeacon = Instantiate(beaconPrefab, pose.position, pose.rotation);
        Debug.Log("Active beacon is : ", _activeBeacon);
        _beaconSet = true;
    }

    private void DeleteBeacon()
    {
        Destroy(_activeBeacon);
        _beaconSet = false;
    }
    
}
