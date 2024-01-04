using UnityEngine;
namespace Dependency_Inversion_Principle
{
    [CreateAssetMenu(menuName = "Car/Settings",fileName = "ShipData")]
    public class CarSetting : ScriptableObject
    {
        [SerializeField] private float turnSpeed = 25f;
        [SerializeField] private float moveSpeed = 10f;
        [SerializeField] private bool useAi = false;

        public float TurnSpeed { get { return turnSpeed; } }
        public float MoveSpeed { get { return moveSpeed; } }
        public bool UseAi { get { return useAi; } }
      
    }
}