using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Single_Responsibility_Principle
{    public class Projectile : MonoBehaviour
    {
        private float speed = 10f; // Speed of the projectile
        public int Damage = 10;  // Damage inflicted by the projectile

        private void Start()
        {
            Invoke("DestroyeProjectile", 2);
        }
        private void Update()
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        private void DestroyeProjectile()
        {
            Destroy(this.gameObject);
        }


    }
}

