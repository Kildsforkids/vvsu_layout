using System.Collections.Generic;
using UnityEngine;

public class Floors : MonoBehaviour
{
    private List<GameObject[]> floors = new List<GameObject[]>();

    private int currentFloorIndex = 1;

    private void Start()
    {
        floors.Add(GameObject.FindGameObjectsWithTag("floor7"));
        floors.Add(GameObject.FindGameObjectsWithTag("floor6"));
        floors.Add(GameObject.FindGameObjectsWithTag("floor5"));
        floors.Add(GameObject.FindGameObjectsWithTag("floor4"));

        foreach (var floor in floors)
        {
            foreach (var element in floor)
            {
                element.SetActive(false);
            }
        }
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
                    element.SetActive(true);
                }
                //floors[currentFloorIndex].SetActive(false);
                // floors[++currentFloorIndex].SetActive(true);
            }
        }
    }
    public void Set_Bool()   
    {
        currentFloorIndex = 1;
    }
}