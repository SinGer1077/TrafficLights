using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficController : MonoBehaviour
{
   private List<GameObject> _cars = new List<GameObject>();

   public void AddCar(GameObject car)
    {
        _cars.Add(car);
    }

    public void StopCars()
    {
        foreach (GameObject car in _cars)
        {
            car.GetComponent<CarMover>().StopCar();
        }
    }

    public void MoveCars()
    {
        foreach (GameObject car in _cars)
        {
            car.GetComponent<CarMover>().MoveCar();
        }
    }
}
