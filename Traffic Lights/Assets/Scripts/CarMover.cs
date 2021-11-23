using UnityEngine;

public class CarMover : MonoBehaviour
{
    private float _movingSpeed = 1.0f;

    public float MovingSpeed => _movingSpeed;

    private Transform _destinationPoint;

    public Transform DestinationPoint => _destinationPoint;

    private Vector3 _startPosition;

    private float _startTime;

    private void Start()
    {
        _startPosition = transform.position;
        _startTime = Time.time;
    }

    private void Update()
    {
        if (_destinationPoint != null)
        {
            transform.position = Vector3.Lerp(_startPosition, _destinationPoint.position, Time.time - _startTime * _movingSpeed);
        }
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
