using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Interface_Segregation_Principle
{
    public class Archer : MonoBehaviour,IShootable
    {
        public bool IsFireWeapon()
        {
            return Input.GetButtonDown("Fire1");
        }
        public void Shoot()
        {
            if(IsFireWeapon())
            Debug.Log("Archer Shoot");
        }      
    }
}