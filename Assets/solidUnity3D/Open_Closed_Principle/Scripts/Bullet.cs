using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Open_Closed_Principle
{ 
    public class Bullet : MonoBehaviour
    {
        private float speed = 10f; // Speed of the projectile
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