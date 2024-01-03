using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Liskov_Substitution_Principal
{
    public class NPC : Character
    {
        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount * 5);
        }
    }
}