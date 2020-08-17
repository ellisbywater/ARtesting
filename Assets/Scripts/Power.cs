using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public GameObject powerPrefab;
    public float powerSpeed;
    public float powerRechargeTime;
    public Rigidbody Rigidbody;
    public float lifeTime;

    private float _rechargeTimer;

    private void Update()
    {
        if (_rechargeTimer > 0)
            _rechargeTimer -= Time.deltaTime;
        
    }

    private void LateUpdate()
    {
        Rigidbody.velocity = transform.forward * powerSpeed;    
    }
}
