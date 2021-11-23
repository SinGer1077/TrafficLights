using UnityEngine;

public class CarsSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _carPrefab;

    [SerializeField]
    private int _countToSpawn;

    [SerializeField]
    private float _timeBetweenSpawning = 1.0f;

    [SerializeField]
    private Transform _destinationPoint;    

    [SerializeField]
    private TrafficController _traffic;



    private bool _isReadyToSpawn = true;

    private float _spawnedCars = 0f;

    private float _timer = 0f;

    private void Start()
    {
        _timer = _timeBetweenSpawning;
    }

    private void Update()
    {
        if (_isReadyToSpawn)
        {
            _timer += Time.deltaTime;
            if (_timer >= _timeBetweenSpawning)
            {
                if (_spawnedCars < _countToSpawn)
                {
                    Spawn();
                    _spawnedCars++;
                    _timer = 0;
                }
            }
        }
    }

    public void SetCountToSpawn(int count)
    {
        _countToSpawn = count;
    }

    public void Spawn()
    {
        GameObject car = Instantiate(_carPrefab, transform);
        car.GetComponent<CarMover>().SetDestinationPoint(_destinationPoint);
        _traffic.AddCar(car);
    }

    public void StopSpawn()
    {
        _isReadyToSpawn = false;
    }

    public void ContinueSpawn()
    {
        _isReadyToSpawn = true;
    }

    public void ClickOnTraffic()
    {
        if (_isReadyToSpawn)
        {
            StopSpawn();
        }
        else
        {
            ContinueSpawn();
        }
    }
}
