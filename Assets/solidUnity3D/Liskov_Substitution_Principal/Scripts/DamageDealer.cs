using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace Liskov_Substitution_Principal
{
    public class DamageDealer : MonoBehaviour
    {
        private void Update()
        {
            if(Input.GetButtonDown("Fire1"))
            {
                DealDamageToNearestCharacter();
            }
        }

        private void DealDamageToNearestCharacter()
        {
            Character nearestchar = FindObjectsOfType<Character>()
                .OrderBy(t => 
                Vector3.Distance(transform.position, t.transform.position))
                .FirstOrDefault();

            int damageToDeal = 1;

            nearestchar.TakeDamage(damageToDeal);
        }
    }
}