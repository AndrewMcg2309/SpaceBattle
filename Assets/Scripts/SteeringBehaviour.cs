using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[RequireComponent (typeof(Cruiser))]
public abstract class SteeringBehaviour : MonoBehaviour
{
    public float weight = 1.0f;
    public Vector3 force;

    [HideInInspector]
    public Cruiser cruiser;

    public void Awake()
    {
        cruiser = GetComponent<Cruiser>();
    }

    public abstract Vector3 Calculate();
}