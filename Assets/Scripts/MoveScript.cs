using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Transform[] points;
    public Transform obj;
    public float speed;

    private Transform targetPoint;
    private int currentPoint;
    void Start()
    {
        currentPoint = 0;
        targetPoint = points[currentPoint];
    }

    void Update()
    {
        if(obj.position == targetPoint.position)
        {
            currentPoint++;

            currentPoint = currentPoint % (points.Length + 1);

            targetPoint = points[currentPoint];
        }

        obj.position = Vector3.MoveTowards(obj.position, targetPoint.position, speed * Time.deltaTime);
    }
}
