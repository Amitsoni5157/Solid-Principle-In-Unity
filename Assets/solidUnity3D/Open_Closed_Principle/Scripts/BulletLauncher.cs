using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Open_Closed_Principle
{
    public class BulletLauncher : MonoBehaviour, ILauncher
    {

        [SerializeField]
        private Bullet bulletPrefab;
        [SerializeField]
        private Transform WeaponPoint;

        public void Launch(Weapon weapon)
        {
            var bullet = Instantiate(bulletPrefab, WeaponPoint.position, WeaponPoint.rotation);
        }
    }
}