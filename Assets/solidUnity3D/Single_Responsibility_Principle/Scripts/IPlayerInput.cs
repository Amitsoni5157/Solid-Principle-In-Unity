using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Interface_Segregation_Principle
{
    public interface IPlayerInput
    {
        float GetHorizontalInput();
        float GetVerticalInput();

    }
}