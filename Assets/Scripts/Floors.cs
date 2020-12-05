using System.Collections.Generic;
using UnityEngine;

public class Floors : MonoBehaviour
{
    private List<GameObject[]> floors = new List<GameObject[]>();

    private int currentFloorIndex = 0;

    private void Start()
    {
        floors.Add(GameObject.FindGameObjectsWithTag("floor7"));
        floors.Add(GameObject.FindGameObjectsWithTag("floor6"));
        floors.Add(GameObject.FindGameObjectsWithTag("floor5"));
        floors.Add(GameObject.FindGameObjectsWithTag("floor4"));
    }
    public void SetActiveNextFloor(bool up)
    {
        if (up)
        {
            if (currentFloorIndex - 1 >= 0)
            {
                foreach(var element in floors[currentFloorIndex])
                {
                    element.SetActive(false);
                }
                foreach (var element in floors[--currentFloorIndex])
                {
                    element.SetActive(true);
                }
                //floors[currentFloorIndex].SetActive(false);
                //floors[--currentFloorIndex].SetActive(true);
            }
        }
        else
        {
            if (currentFloorIndex + 1 < floors.Count)
            {
                foreach (var element in floors[currentFloorIndex])
                {
                    element.SetActive(false);
                }
                foreach (var element in floors[++currentFloorIndex])
                {
                    element.SetActive(false);
                }
                //floors[currentFloorIndex].SetActive(false);
                // floors[++currentFloorIndex].SetActive(true);
            }
        }
    }
}