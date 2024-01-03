using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{

    [SerializeField]
    private Rigidbody projectilePrefab;
    [SerializeField]
    private Transform WeaponPoint;
    [SerializeField]
    private float fireForce = 300f;
    
    private void Awake()
    {
        GetComponent<PlayerInput>().OnFire += HandleFire;
    }

    private void HandleFire()
    {
        var spawnedProjectile = Instantiate(projectilePrefab,WeaponPoint.position,WeaponPoint.rotation);
        spawnedProjectile.AddForce(spawnedProjectile.transform.forward * fireForce);
    }
}
