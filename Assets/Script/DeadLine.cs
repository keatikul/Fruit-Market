using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLine : MonoBehaviour
{
    public GameObject GameOverCanvas;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Collider");
        if (collision.tag == "Basket")
        {
            
            GameOverCanvas.SetActive(true);
            Ball.Instance.DesactivateRb();
            Manager.instantiateManager.timeValue = 0;
        }
    }
}
