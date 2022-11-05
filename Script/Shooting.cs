using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;

    public Vector2 minPower;
    public Vector2 maxPower;

    TarjectoryLine tl;

    Camera cam;
    Vector2 force;
    Vector2 startPoint;
    Vector2 endPoint;
    Vector2 currentPoint;

    public bool isShooting;
    public static Shooting instantiateShooting;
    private void Start()
    {
        cam = Camera.main;
        MakeSingleton();
        tl = GetComponent<TarjectoryLine>();
    }

    public void MakeSingleton()
    {
        if (instantiateShooting == null)
        {
            instantiateShooting = this;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            //startPoint.z = 15;
            //Debug.Log(startPoint);
        }

        if (Input.GetMouseButton(0))
        {
            currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            //Vector3 startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            //currentPoint.z = 15;
            //currentPoint.y = 8;
            //startPoint.y = 8;
            tl.RenderLine(startPoint,currentPoint);
        }

        if (Input.GetMouseButtonUp(0))
        {
            
            endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            //endPoint.z = 15;
            //endPoint.y = 8;
            //force = CalculatePowerVectorV2(startPoint,endPoint );
            force = new Vector2(startPoint.x - endPoint.x,startPoint.y - endPoint.y);
            //force = new Vector2(Mathf.Clamp(startPoint.x - currentPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - currentPoint.y, minPower.y, maxPower.y))*;
            rb.AddForce(force * power, ForceMode2D.Impulse);
            isShooting = true;
            tl.EndLine();
            Manager.instantiateManager.shootcount++;
        }


    }

    private Vector2 CalculatePowerVectorV2(Vector2 startPoint, Vector2 endPoint)
    {
        Vector2 difference = startPoint - endPoint;
        float vectorPower = difference.magnitude;
        vectorPower = Mathf.Clamp(vectorPower, -10, 10);

        return difference.normalized * vectorPower;



    }
}
