﻿using UnityEngine;

public class vvsu : MonoBehaviour
{
    [SerializeField]
    private GameObject _window;
    // Update is called once per frame
    private void OnMouseDown()
    {
        if (_window.activeInHierarchy==false)
            Application.OpenURL("http://vvsu.ru/");
        
    }
}
