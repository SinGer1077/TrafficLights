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
            Instantiate(_carPrefab, transform);
            yield return new WaitForSeconds(_timeBetweenSpawning);
        }
    }
}
