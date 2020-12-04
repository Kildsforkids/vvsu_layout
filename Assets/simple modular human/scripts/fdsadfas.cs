using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveNPC : MonoBehaviour
{
    public float dist;

    public float speed;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed);
        Raycast();


    }

    private void Raycast()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, dist))
        {
            transform.Rotate(180, 0, 0);
        }
    }
}