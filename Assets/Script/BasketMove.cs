using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMove : MonoBehaviour
{
    public float timeValue = 0f;
    public bool Moving;
    public bool FinishBasket;
    public GameObject[] gos;
    void Start()
    {
        
    }

    public void TimeCount()
    {
        if (timeValue < 5)
        {
            //timeValue += Time.deltaTime;
        }
        else
        {
            Moving = true;
            timeValue = 0;
        }
        
        MovingBasket();
    }

    public void MovingBasket()
    {
        gos = GameObject.FindGameObjectsWithTag("Basket");
        if (gos.Length < 20)
        {
            FinishBasket = true;
        }
        if (FinishBasket == true)
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y - 1.00f, transform.position.z);
            //GenBasket.genBasket.CreateNew();
            FinishBasket = false;
        }
        

        if (Moving == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1.00f, transform.position.z);
            Moving = false;
            //GenBasket.genBasket.CreateNew();
        }

    }

    
    // Update is called once per frame
    void Update()
    {
        TimeCount();
    }
}
