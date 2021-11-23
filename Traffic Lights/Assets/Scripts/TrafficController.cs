using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrafficController : MonoBehaviour
{
    [SerializeField]
    private GameState _gameState;

    [SerializeField]
    private float _carsSpeed;

    private List<GameObject> _cars = new List<GameObject>();

    public List<GameObject> Cars => _cars;

    private ColorData _colorData;

    private bool _isMoving = true;

    private void Start()
    {
        _colorData = GetComponent<Colorizer>().ColorData;
    }

    public void AddCar(GameObject car)
    {
        car.GetComponent<Colorizer>().SetColorData(_colorData);
        car.GetComponent<CarTriggers>().CollisionEvents.AddListener(_gameState.Lose);

        CarMover mover = car.GetComponent<CarMover>();
        mover.SetController(this);
        mover.SetSpeed(_carsSpeed);       
        mover.ArriveEvents.AddListener(_gameState.IncreaseCounter);

        _cars.Add(car);

    }

    public void StopCars()
    {
        _isMoving = false;
        foreach (GameObject car in _cars)
        {
            car.GetComponent<CarMover>().StopCar();
        }
    }

    public void MoveCars()
    {
        _isMoving = true;
        foreach (GameObject car in _cars)
        {
            car.GetComponent<CarMover>().MoveCar();
        }
    }

    public void ClickOnTraffic()
    {
        if (_isMoving)
        {
            GetComponent<Colorizer>().ChangeAlpha(0.5f);
            StopCars();
        }
        else
        {
            GetComponent<Colorizer>().ChangeAlpha(1.0f);
            MoveCars();
        }
    }

}
