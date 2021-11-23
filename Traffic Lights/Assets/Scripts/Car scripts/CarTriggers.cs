using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CarTriggers : MonoBehaviour
{
    private UnityEvent _event;

    public UnityEvent CollisionEvents => _event;

    private void OnCollisionEnter(Collision collision)
    {
        _event.Invoke();
    }
}
