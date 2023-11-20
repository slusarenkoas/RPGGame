using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePotion : MonoBehaviour
{
    [SerializeField] private GameObject _potion;

    private Outline _outline;
    public bool isActivatedPotion { get; private set; }

    private void Start()
    {
        _outline = GetComponent<Outline>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == _potion.GetComponent<Collider>() && !isActivatedPotion)
        {
            _potion.GetComponent<MeshRenderer>().enabled = false;
            _outline.OutlineWidth = 2;
            isActivatedPotion = true;
        }
    }
}
