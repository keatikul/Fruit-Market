using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMove : MonoBehaviour
{
    public float timeValue = 0f;
    public bool Moving;
    public bool FinishBasket;
    public GameObject[] gos;
    public static BasketMove instanceBasketMove;
    public GameObject BasketParents;

    private void Start()
    {
        MakeSingleton();
    }
    void MakeSingleton()
    {
       if (instanceBasketMove == null)
        {
            instanceBasketMove = this;
        }
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
    }
    
    
    
    // Update is called once per frame

}
