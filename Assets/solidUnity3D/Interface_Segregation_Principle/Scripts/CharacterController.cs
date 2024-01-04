using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interface_Segregation_Principle
{
    public class CharacterController : MonoBehaviour
    {

        private IMovable movable;
        private IShootable shootable;


        // Start is called before the first frame update
        void Start()
        {
            movable = GetComponent<IMovable>();
            shootable = GetComponent<IShootable>();
        }

        // Update is called once per frame
        void Update()
        {
            if(movable != null)
            {
                movable.Move();
            }

            if(shootable != null)
            {
                shootable.Shoot();
            }
        }



    }
}