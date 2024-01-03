using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParticles : MonoBehaviour
{
    [SerializeField]
    private GameObject thrusterParticle;
    [SerializeField]
    private GameObject deathParticleSystemPrefab;

    private void Awake()
    {
        GetComponent<PlayerMovement>().thrustChanged += HandleThrustChanged;

        if (GetComponent<PlayerHealth>() != null)
            GetComponent<PlayerHealth>().OnDie += HandlePlayerChanged;
    }

    private void HandleThrustChanged(float thrust)
    {
        thrusterParticle.SetActive(thrust > 0);
    }

    private void HandlePlayerChanged()
    {
        Instantiate(deathParticleSystemPrefab, transform.position, Quaternion.identity);
    }

}
