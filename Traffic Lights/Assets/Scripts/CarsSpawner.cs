using System.Collections;
using System.Collections.Generic;
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

    public int CountToSpawn => _countToSpawn;

    private void Start()
    {
        StartCoroutine("Spawn");
    }

    public void SetCountToSpawn(int count)
    {
        _countToSpawn = count;
    }

    public IEnumerator Spawn()
    {
        for (int i = 0; i < _countToSpawn; i++)
        {
            GameObject car = Instantiate(_carPrefab, transform);
            car.GetComponent<CarMover>().SetDestinationPoint(_destinationPoint);
            _traffic.AddCar(car);

            yield return new WaitForSeconds(_timeBetweenSpawning);
        }
    }
}
