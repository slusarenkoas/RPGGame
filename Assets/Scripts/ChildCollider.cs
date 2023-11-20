using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCollider : MonoBehaviour
{
    private Chest _chest;

    private void Start()
    {
        _chest = GetComponentInParent<Chest>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _chest.Open();
        }
    }
}
