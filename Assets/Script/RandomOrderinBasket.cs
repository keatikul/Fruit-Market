using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RandomOrderinBasket : MonoBehaviour
{
    public GameObject Order1;
    public GameObject Order2;
    public GameObject Order3;
    public GameObject Basket;

    private int index;
    private int index2;
    private int index3;

    public SpriteRenderer SpriteRenderer1;
    public SpriteRenderer SpriteRenderer2;
    public SpriteRenderer SpriteRenderer3;

    public int tagFruit;
    public float dmg = 0f;

    public List<int> orderdata = new List<int>();
    public List<int> wrongorder = new List<int>();
    public Sprite[] spritesArray;
    
    //public List<GameObject> Heart = new List<GameObject>();

    public static RandomOrderinBasket InstanceRandom;



    //Game Start
    //Random Number for order
    //Add number from random to Data
    //Change order from data
    //if fruit hit basket
    //check fruit is correct?
    //change data order to correct
    private void Start()
    {
        index = Random.Range(1, 6);
        index2 = Random.Range(1, 6);
        index3 = Random.Range(1, 6);

        
        /*Debug.Log("Index1: " + index);
        Debug.Log("Index2: " + index2);
        Debug.Log("Index3: " + index3);*/
        Order();
        MakeSingleton();
    }


    public void MakeSingleton()
    {
        if (InstanceRandom == null)
        {
            InstanceRandom = this;
        }
    }

    private void Update()
    {
        //CheckIsCorrect();
        OrderSuccess();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "1(Clone)")
        {
            tagFruit = 1;
            Destroy(collision.gameObject);
            CheckIsCorrect();
            //GenFruit.instantiateGenFruit.RandomMatterialFruit();
        }
        if (collision.gameObject.name == "2(Clone)")
        {
            tagFruit = 2;
            Destroy(collision.gameObject);
            CheckIsCorrect();
            //GenFruit.instantiateGenFruit.RandomMatterialFruit();
        }
        if (collision.gameObject.name == "3(Clone)")
        {
            tagFruit = 3;
            Destroy(collision.gameObject);
            CheckIsCorrect();
            //GenFruit.instantiateGenFruit.RandomMatterialFruit();
        }
        if (collision.gameObject.name == "4(Clone)")
        {
            tagFruit = 4;
            Destroy(collision.gameObject);
            CheckIsCorrect();
            //GenFruit.instantiateGenFruit.RandomMatterialFruit();
        }
        if (collision.gameObject.name == "5(Clone)")
        {
            tagFruit = 5;
            Destroy(collision.gameObject);
            CheckIsCorrect();
            //GenFruit.instantiateGenFruit.RandomMatterialFruit();
        }
        //CheckIsCorrect();
        
        //GenFruit.instantiateGenFruit.orderleft.Clear();
        GenFruit.instantiateGenFruit.ReadytoAdd = true;
        GenFruit.instantiateGenFruit.Readytogen = true;
    }

    public void CheckIsCorrect()
    {
        /*for (int i = 0; i <= orderdata.Count; i++)
        {
            if (tagFruit == orderdata[0])
            {
                SpriteRenderer1.color = Color.clear;
                orderdata.RemoveAt(orderdata.Count - 1);
            
            }
            else if (tagFruit == orderdata[1])
            {
                SpriteRenderer2.color = Color.clear;
                orderdata.RemoveAt(orderdata.Count - 1);
            }
            else if (tagFruit == orderdata[2])
            {
                SpriteRenderer3.color = Color.clear;
                orderdata.RemoveAt(orderdata.Count - 1);
            }
        }*/
       
        if (tagFruit == orderdata[0])
        {
            SpriteRenderer1.color = Color.clear;
            //orderdata.RemoveAt(orderdata.Count - 1);
            orderdata[0] = 0;
            //GenFruit.instantiateGenFruit.orderleft.Clear();
            
        }
        else if (tagFruit == orderdata[1])
        {
            SpriteRenderer2.color = Color.clear;
            //orderdata.RemoveAt(orderdata.Count - 1);
            orderdata[1] = 0;
            //GenFruit.instantiateGenFruit.orderleft.Clear();
        }
        else if (tagFruit == orderdata[2])
        {
            SpriteRenderer3.color = Color.clear;
            //orderdata.RemoveAt(orderdata.Count - 1);
            orderdata[2] = 0;
            //GenFruit.instantiateGenFruit.orderleft.Clear();
        }
        else
        {
            dmg = 1f;
            //Manager.instantiateManager.Scoore--;
            HealthBarHUDTester.Instance.TakeDamage(dmg);
            
            wrongorder.Add(tagFruit);
        }
    }


    public void OrderSuccess()
    {
        if (orderdata[0] == 0 && orderdata[1] == 0 && orderdata[2] == 0)
        {
            Manager.instantiateManager.Scoore++;
            //this.Basket.SetActive(false);
            Destroy(this.Basket);
            //GenBasket.genBasket.randomOrderinBaskets.RemoveAt(0);
        }
    }

    /*public void CheckingifOrderthesame()
    {
        if (orderdata[0] == orderdata[1] || orderdata[0] == orderdata[2] || orderdata[1] == orderdata[2])
        {
            Debug.Log("Order same");
        }
    }*/
    
    public void Order()
    {
        if (index == 1)
        {
            Debug.Log("Red");
            SpriteRenderer1.sprite = spritesArray[0];
            orderdata.Add(index);
        }
        if (index == 2)
        {
            Debug.Log("Blue");
            SpriteRenderer1.sprite = spritesArray[1];
            orderdata.Add(index);
        }
        if (index == 3)
        {
            Debug.Log("Green");
            SpriteRenderer1.sprite = spritesArray[2];
            orderdata.Add(index);
        }
        if (index == 4)
        {
            Debug.Log("Yellow");
            SpriteRenderer1.sprite = spritesArray[3];
            orderdata.Add(index);
        }
        if (index == 5)
        {
            Debug.Log("Pink");
            SpriteRenderer1.sprite = spritesArray[4];
            orderdata.Add(index);
        }


        if (index2 == 1)
        {
            Debug.Log("Red");
            SpriteRenderer2.sprite = spritesArray[0];
            orderdata.Add(index2);
        }
        if (index2 == 2)
        {
            Debug.Log("Blue");
            SpriteRenderer2.sprite = spritesArray[1];
            orderdata.Add(index2);
        }
        if (index2 == 3)
        {
            Debug.Log("Green");
            SpriteRenderer2.sprite = spritesArray[2];
            orderdata.Add(index2);
        }
        if (index2 == 4)
        {
            Debug.Log("Yellow");
            SpriteRenderer2.sprite = spritesArray[3];
            orderdata.Add(index2);
        }
        if (index2 == 5)
        {
            Debug.Log("Pink");
            SpriteRenderer2.sprite = spritesArray[4];
            orderdata.Add(index2);
        }


        if (index3 == 1)
        {
            Debug.Log("Red");
            SpriteRenderer3.sprite = spritesArray[0];
            orderdata.Add(index3);
        }
        if (index3 == 2)
        {
            Debug.Log("Blue");
            SpriteRenderer3.sprite = spritesArray[1];
            orderdata.Add(index3);
        }
        if (index3 == 3)
        {
            Debug.Log("Green");
            SpriteRenderer3.sprite = spritesArray[2];
            orderdata.Add(index3);
        }
        if (index3 == 4)
        {
            Debug.Log("Yellow");
            SpriteRenderer3.sprite = spritesArray[3];
            orderdata.Add(index3);
        }
        if (index3 == 5)
        {
            Debug.Log("Pink");
            SpriteRenderer3.sprite = spritesArray[4];
            orderdata.Add(index3);
        }
    }
    public void NewRandom()
    {
        index = Random.Range(1, 6);
        index2 = Random.Range(1, 6);
        index3 = Random.Range(1, 6);
        orderdata.RemoveRange(0, 3);
        /*Debug.Log("Index1: " + index);
        Debug.Log("Index2: " + index2);
        Debug.Log("Index3: " + index3);*/
        Order();
    }
}
