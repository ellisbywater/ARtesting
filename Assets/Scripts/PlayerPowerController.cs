using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerController : MonoBehaviour
{
    public static PlayerPowerController Instance;
    public Camera cam;
    public GameObject power;

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            PowerActivate();
        }
    }

    public void PowerActivate()
    {
        Instantiate(power, cam.transform.position, cam.transform.rotation);
    }
}
