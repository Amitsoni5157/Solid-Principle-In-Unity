using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Dependency_Inversion_Principle
{
    public class CarMotor
    {
        private readonly ICarInput carInput;
        private readonly Transform transformToMove;
        private readonly CarSetting carsettings;

        public CarMotor(ICarInput _carInput, Transform _transformToMove, CarSetting _carSetting)
        {
            this.carInput = _carInput;
            this.transformToMove = _transformToMove;
            this.carsettings = _carSetting;
        }

        public void Tick()
        {
            transformToMove.Rotate(Vector3.up * carInput.Rotation * Time.deltaTime * carsettings.TurnSpeed);
            transformToMove.position += transformToMove.forward * carInput.Thrust * Time.deltaTime * carsettings.MoveSpeed;
        }

    }
}