using UnityEngine;
using System.Collections.Generic;
public class BotWalk : MonoBehaviour
{
    
    [SerializeField]
    private List<GameObject> floor = new List<GameObject>();
    Vector3 _targetPoint;
    private float _speed = 1.0f;
    private int i = 0;
    const double PI = 3.14159265;


    void Start()
    {
        _targetPoint = floor[i].transform.position; // Указываешь нужные координаты
        double tg = Mathf.Atan((floor[i].transform.position.x - transform.position.x) / (floor[i].transform.position.z - transform.position.z)) * 180.0 / PI;
        if (floor[i].transform.position.z < transform.position.z)
            tg += 180;
        transform.rotation = Quaternion.Euler(0, (float)tg, 0);

    }

    void FixedUpdate()
    {
        

        MoveObj(); // Вызываем метод для движения, вызов происходит каждый фрейм или что то вроде того
        if (transform.position == _targetPoint)
        {
            i++;
            _targetPoint = floor[i].transform.position;
            double tg = Mathf.Atan((floor[i].transform.position.x - transform.position.x) / (floor[i].transform.position.z - transform.position.z))*180.0/PI;
            if (floor[i].transform.position.z < transform.position.z)
                tg += 180;
            transform.rotation= Quaternion.Euler(0,(float)tg,0);
        }
        if (i+1 == floor.Count)
            i = 0;
    }

    void MoveObj()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPoint, _speed);
              //Двигаем объект с помощью метода MoveTowards, в скобках слева на право 1. Текущее положение, 2. Точка назначения, 3. скорость

    }
}