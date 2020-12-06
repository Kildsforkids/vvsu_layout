using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action_UI : MonoBehaviour
{
    [SerializeField]
    GameObject gameObject_2;

    public void Click()
    {
        if (gameObject.activeSelf == true)
        {

            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }

}