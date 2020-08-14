using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerController : MonoBehaviour
{
    public static PlayerPowerController Instance;
    public GameObject powerPrefab;

    public float powerSpeed;

    public float powerRechargeTime;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PowerActivate()
    {
        
    }
}
