using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGen : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Basket")
        {
            Manager.instantiateManager.alreadyCreate = true;
            //GenBasket.genBasket.CreateNew();
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Basket")
        {
            Manager.instantiateManager.alreadyCreate = false;
            //GenBasket.genBasket.CreateNew();
        }
    }
}
