﻿using UnityEngine;

public class CarMover : MonoBehaviour
{
    private float _movingSpeed = 0.5f;

    private Transform _destinationPoint;

    private Vector3 _startPosition;

    private float _timer;

    private bool _isMoving;

    private void Start()
    {
        _startPosition = transform.position;

        MoveCar();
    }

    private void Update()
    {
        if (_destinationPoint != null && _isMoving)
        {
            _timer += Time.deltaTime;
            transform.position = Vector3.Lerp(_startPosition, _destinationPoint.position, _timer * _movingSpeed);           
        }
    }

    public void StopCar()
    {
        _isMoving = false;
    }

    public void MoveCar()
    {
        _isMoving = true;
    }


    public void SetDestinationPoint(Transform point)
    {
        _destinationPoint = point;
    }

    public void SetSpeed(float speed)
    {
        _movingSpeed = speed;
    }
}
