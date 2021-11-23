using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMover : MonoBehaviour
{
    private Transform _destinationPoint;

    public Transform DestinationPoint => _destinationPoint;

    public void SetDestinationPoint(Transform point)
    {
        _destinationPoint = point;
    }
}
