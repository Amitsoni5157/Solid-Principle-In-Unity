using System.Collections;
using UnityEngine;
namespace Dependency_Inversion_Principle
{
    public class AiInput : ICarInput
    {
        public float Rotation { get; private set; }

        public float Thrust  { get; private set; }

        public void ReadInput()
        {
            Rotation = Random.Range(-1f,1f);

            Thrust = Random.Range(-1f, 1f);
        }
    }
}