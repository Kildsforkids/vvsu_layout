using System.Collections.Generic;
using UnityEngine;

public class Floors : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> floors = new List<GameObject>();

    private int currentFloorIndex = 0;

    public void SetActiveNextFloor(bool up)
    {
        if (up)
        {
            if (currentFloorIndex - 1 >= 0)
            {
                floors[currentFloorIndex].SetActive(false);
                floors[--currentFloorIndex].SetActive(true);
            }
        }
        else
        {
            if (currentFloorIndex + 1 < floors.Count)
            {
                floors[currentFloorIndex].SetActive(false);
                floors[++currentFloorIndex].SetActive(true);
            }
        }
    }
}