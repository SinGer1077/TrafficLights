using UnityEngine;

public class CarMover : MonoBehaviour
{
    private float _movingSpeed = 1.0f;

    public float MovingSpeed => _movingSpeed;

    private Transform _destinationPoint;

    public Transform DestinationPoint => _destinationPoint;

    private Vector3 _startPosition;

    private float _startTime;

    private bool _isMoving;

    private void Start()
    {
        _startPosition = transform.position;
        _startTime = Time.time;

        MoveCar();
    }

    private void Update()
    {
        if (_destinationPoint != null && _isMoving)
        {
            transform.position = Vector3.Lerp(_startPosition, _destinationPoint.position, Time.time - _startTime * _movingSpeed);
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
