using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class TarjectoryLine : MonoBehaviour
{
    LineRenderer lr;
    public GameObject fruit;
   

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
        //fruit.transform.position = new Vector3(0,0,0);
    }

    public void RenderLine(Vector3 startpoint, Vector3 endPoint)
    {
        lr.positionCount = 2;
        Vector3[] point = new Vector3[2];
        startpoint = fruit.transform.position;
        //startpoint.y = 8;
        point[0] = endPoint; 
        point[1] = startpoint;

        lr.SetPositions(point);
    }

    public void EndLine()
    {
        lr.positionCount = 0;
    }
}
