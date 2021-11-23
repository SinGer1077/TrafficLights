using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CarTriggers : MonoBehaviour
{
    private UnityEvent _event = new UnityEvent();

    public UnityEvent CollisionEvents => _event;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _event.Invoke();
    }
}
