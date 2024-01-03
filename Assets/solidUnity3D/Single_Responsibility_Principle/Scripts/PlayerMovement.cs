using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 30f;
    [SerializeField]
    private float turnSpeed = 5f;

    private PlayerInput playerInput;

    private float lastthrust = float.MinValue;

    public event Action<float> thrustChanged = delegate { };

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        if (lastthrust != playerInput.Vertical)
            thrustChanged(playerInput.Vertical);

        lastthrust = playerInput.Vertical;

        transform.position += Time.deltaTime * playerInput.Vertical * transform.forward * speed;
        transform.Rotate(Vector3.up * playerInput.Horizontal * turnSpeed * Time.deltaTime);
    }
}
