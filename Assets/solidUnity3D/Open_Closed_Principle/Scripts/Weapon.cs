using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Open_Closed_Principle
{
    public class Weapon : MonoBehaviour
    {
        private ILauncher launcher;

        [SerializeField]
        private float fireRefreshRate = 1f;

        private float nextFireTime;
        private void Awake()
        {
            launcher = GetComponent<ILauncher>();
        }
       
        void Update()
        {
            if(CanFire() && Input.GetButtonDown("Fire1"))
            {
                FireWeapon();
            }
        }
        private bool CanFire()
        {
            return Time.time >= nextFireTime;
        }
        private void FireWeapon()
        {
            nextFireTime = Time.time + fireRefreshRate;
            launcher.Launch(this);
        }
    }
}