using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public GameObject projectile;
    private Transform _projectileOrigin;
    public float projectileSpeed = 15f;
    public float projectileLifetime = 2f;
    private float _shotTimer;
    public float shotGapTime = 0.5f;
    
    [HideInInspector]
    public Camera playerCamera;

    private void Awake()
    {
        Instance = this;
        playerCamera = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_shotTimer > 0)
        {
            _shotTimer -= Time.deltaTime;
        }
        if (Input.touchCount > 0 && _shotTimer <= 0)
        {
            ShootProjectile();
            _shotTimer = shotGapTime;
        }
    }

    void ShootProjectile()
    {
        _projectileOrigin = playerCamera.transform;
        GameObject proj = Instantiate(projectile, _projectileOrigin.position, _projectileOrigin.rotation);
        proj.GetComponent<Rigidbody>().velocity = playerCamera.transform.forward * projectileSpeed;
        Destroy(proj, projectileLifetime);
    }
}
