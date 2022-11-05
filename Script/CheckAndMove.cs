using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAndMove : MonoBehaviour
{


    //???????????? Qeue ???? Stack ???? Move ????? Move ????????
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "Basket")
       {
            Debug.Log("Basket in");
            
       }
    }
}
