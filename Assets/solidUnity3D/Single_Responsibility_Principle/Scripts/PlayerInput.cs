using System;
using UnityEngine;
namespace Single_Responsibility_Principle
{
    public class PlayerInput : MonoBehaviour
    {
        public float Horizontal { get; private set; }
        public float Vertical { get; private set; }
        public bool FireWeapons { get; private set; }

        public event Action OnFire = delegate { };

        // Update is called once per frame
        private void Update()
        {
            Horizontal = Input.GetAxis("Horizontal");
            Vertical = Input.GetAxis("Vertical");
            FireWeapons = Input.GetButtonDown("Fire1");

            if (FireWeapons)
            {
                OnFire();
            }
        }
    }
}