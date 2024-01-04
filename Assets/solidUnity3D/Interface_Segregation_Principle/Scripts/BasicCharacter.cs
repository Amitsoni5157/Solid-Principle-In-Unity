using UnityEngine;
namespace Interface_Segregation_Principle
{
    public class BasicCharacter : MonoBehaviour,IMovable,IPlayerInput
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
        public void Move()
        {
            transform.position += Time.deltaTime * GetVerticalInput() * transform.forward * speed;
            transform.Rotate(Vector3.up * GetHorizontalInput() * turnSpeed * Time.deltaTime);
        }


    }
}