using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Camera mainCam;
    private Vector3 mousPos;
    // Start is called before the first frame update
    void Start()
    {
        //mainCam = GameObject.FindGameObjectsWithTag("MainCamera").
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("Pressed");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            print("Released");
        }
        mousPos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousPos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
