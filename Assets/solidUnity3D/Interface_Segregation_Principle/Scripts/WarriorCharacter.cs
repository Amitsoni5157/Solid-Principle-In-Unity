using UnityEngine;

namespace Interface_Segregation_Principle
{
    public class WarriorCharacter : MonoBehaviour,IMovable,IShootable, IPlayerInput
    {
          [SerializeField]
        private float speed = 30f;
        [SerializeField]
        private float turnSpeed = 5f;

        public float GetHorizontalInput()
        {
            return Input.GetAxis("Horizontal");
        }

        public float GetVerticalInput()
        {
            return Input.GetAxis("Vertical");
        }
        public bool IsFireWeapon()
        {
            return Input.GetButtonDown("Fire1");
        }


        public void Shoot()
        {
            if(IsFireWeapon())
            Debug.Log("Warrior Shoot");
        }
        public void Move()
        {
            transform.position += Time.deltaTime * GetVerticalInput() * transform.forward * speed;
            transform.Rotate(Vector3.up * GetHorizontalInput() * turnSpeed * Time.deltaTime);
        }

       
    }
}