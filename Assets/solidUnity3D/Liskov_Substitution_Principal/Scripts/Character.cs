using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Liskov_Substitution_Principal
{
    public class Character : MonoBehaviour
    {
        [SerializeField]
        private int maxHealth = 100;

        private int currentHealth;

        private void Awake()
        {
            currentHealth = maxHealth;
        }

        public virtual void TakeDamage(int amount)
        {
            currentHealth -= amount;
        }
    }
}