using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Dependency_Inversion_Principle
{
    public class Car : MonoBehaviour
    {
        [SerializeField]
        private CarSetting carSetting;

        private ICarInput carInput;
        private CarMotor carMotor;

        private void Awake()
        {
            carInput = carSetting.UseAi ? new AiInput() as ICarInput : new ControllerInput();

            carMotor = new CarMotor(carInput, transform, carSetting);
        }

        private void Update()
        {
            carInput.ReadInput();
            carMotor.Tick();
        }
    }
}