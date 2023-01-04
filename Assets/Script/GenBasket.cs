using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenBasket : MonoBehaviour
{
    public float Xstart,Ystart;
    public float XnewStart, YnewStart;

    public int colLength, rowLength;
    public int n_colLength, n_rowLength;
    public float Xspace, Yspace;
    public GameObject Basket;
    public static GenBasket genBasket;
    public GameObject[] firstCol;
    public int numOfbasket;
    public bool ReadytoUse = false;
    public bool ReadytoAdd = false;
    public int m;
    public int checkint = 0;
    GameObject basket;
    public Transform ParentBasket;
   


    public List<int> n_orderdata = new List<int>();

    public List<RandomOrderinBasket> randomOrderinBaskets = new List<RandomOrderinBasket>();
    public List<RandomOrderinBasket> randomOrderinBaskets2 = new List<RandomOrderinBasket>();
    public List<RandomOrderinBasket> randomOrderinBaskets3 = new List<RandomOrderinBasket>();
    public List<RandomOrderinBasket> randomOrderinBaskets4 = new List<RandomOrderinBasket>();


    private void Start()
    {
        CreateBasket();
        
        MakeSingleton();
        //RandomFromList();
        //GenFruit.instantiateGenFruit.CheckOrderdata();
        //GenFruit.instantiateGenFruit.RandomMatterialFruit();
    }

    public void MakeSingleton()
    {
        if (genBasket == null)
        {
            genBasket = this;
        }
    }

    public void CreateBasket()
    {
        //
        //while(checkint < 4)
        {
            for (int i = 0; i < colLength * rowLength; i++)
            {
                basket = Instantiate(Basket, new Vector3(Xstart + (Xspace * (i % colLength)), Ystart + (Yspace * (i / colLength))), Quaternion.identity, ParentBasket);
                
                Basket.name = "Basket: " + numOfbasket++;
                randomOrderinBaskets.Add(basket.GetComponent<RandomOrderinBasket>());
                //firstCol.Add(Basket);
                //ต้องรู้ว่า int ที่เท่าไหร่คือแถวที่เท่าไหร่ จากนั้นทำ List แยก 4 แถว
            }
            for (int i = 0; i < colLength * rowLength; i++)
            {
                basket = Instantiate(Basket, new Vector3(-1.7f + (Xspace * (i % colLength)), Ystart + (Yspace * (i / colLength))), Quaternion.identity, ParentBasket);
                
                Basket.name = "Basket: " + numOfbasket++;
                randomOrderinBaskets2.Add(basket.GetComponent<RandomOrderinBasket>());
                //firstCol.Add(Basket);
                //ต้องรู้ว่า int ที่เท่าไหร่คือแถวที่เท่าไหร่ จากนั้นทำ List แยก 4 แถว
            }
            for (int i = 0; i < colLength * rowLength; i++)
            {
                basket = Instantiate(Basket, new Vector3(1.8f + (Xspace * (i % colLength)), Ystart + (Yspace * (i / colLength))), Quaternion.identity, ParentBasket);
                
                Basket.name = "Basket: " + numOfbasket++;
                randomOrderinBaskets3.Add(basket.GetComponent<RandomOrderinBasket>());
                //firstCol.Add(Basket);
                //ต้องรู้ว่า int ที่เท่าไหร่คือแถวที่เท่าไหร่ จากนั้นทำ List แยก 4 แถว
            }
            for (int i = 0; i < colLength * rowLength; i++)
            {
                basket = Instantiate(Basket, new Vector3(5.3f + (Xspace * (i % colLength)), Ystart + (Yspace * (i / colLength))), Quaternion.identity, ParentBasket);
                
                Basket.name = "Basket: " + numOfbasket++;
                randomOrderinBaskets4.Add(basket.GetComponent<RandomOrderinBasket>());
                //firstCol.Add(Basket);
                //ต้องรู้ว่า int ที่เท่าไหร่คือแถวที่เท่าไหร่ จากนั้นทำ List แยก 4 แถว
            }
            checkint++;
            GenFruit.instantiateGenFruit.ReadytoAdd = true;
            GenFruit.instantiateGenFruit.Readytogen = true;
            
            //GenFruit.instantiateGenFruit.CheckOrderdata();
            /*if (checkint == 1)
            {
                for (int i = 0; i < colLength * rowLength; i++)
                {
                    randomOrderinBaskets.Add(basket.GetComponent<RandomOrderinBasket>());
                }
            }
            if (checkint == 2)
            {
                for (int i = 0; i < colLength * rowLength; i++)
                {
                    randomOrderinBaskets2.Add(basket.GetComponent<RandomOrderinBasket>());
                }
            }
            if (checkint == 3)
            {
                for (int i = 0; i < colLength * rowLength; i++)
                {
                    randomOrderinBaskets3.Add(basket.GetComponent<RandomOrderinBasket>());
                }
            }
            if (checkint == 4)
            {
                for (int i = 0; i < colLength * rowLength; i++)
                {
                    randomOrderinBaskets4.Add(basket.GetComponent<RandomOrderinBasket>());
                }
            }*/
        }

        firstCol = GameObject.FindGameObjectsWithTag("Basket");
        ReadytoUse = true;
        /*for (int j = 0; j < colLength; j++)
        {
            firstCol.Add(Basket);
        }*/
    }

    public void CreateNew()
    {
        this.Ystart = 9.34f;
        Debug.Log("CreateNew");
        //this.rowLength = 1;
        /*for (int i = 0; i < colLength * rowLength; i++)
        {
            Instantiate(Basket, new Vector3(Xstart + (Xspace * (i % colLength)), Ystart + (Yspace * (i / colLength))), Quaternion.identity);
        }*/
        /*for (int i = 0; i < n_colLength * n_rowLength; i++)
        {
            Instantiate(Basket, new Vector3(Xstart + (Xspace * (i % colLength)), Ystart + (Yspace * (i / colLength))), Quaternion.identity);
            //Instantiate(Basket, new Vector3(XnewStart + (Xspace * (i % n_colLength)), YnewStart + (Yspace * (i / n_colLength))), Quaternion.identity);
        }*/
        for (int i = 0; i < n_colLength * n_rowLength; i++)
        {
            basket = Instantiate(Basket, new Vector3(Xstart + (Xspace * (i % n_colLength)), Ystart + (Yspace * (i / n_colLength))), Quaternion.identity, ParentBasket);
            Basket.name = "Basket: " + numOfbasket++;
            randomOrderinBaskets.Add(basket.GetComponent<RandomOrderinBasket>());
            //firstCol.Add(Basket);
            //ต้องรู้ว่า int ที่เท่าไหร่คือแถวที่เท่าไหร่ จากนั้นทำ List แยก 4 แถว
        }
        for (int i = 0; i < n_colLength * n_rowLength; i++)
        {
            basket = Instantiate(Basket, new Vector3(-1.7f + (Xspace * (i % n_colLength)), Ystart + (Yspace * (i / n_colLength))), Quaternion.identity, ParentBasket);

            Basket.name = "Basket: " + numOfbasket++;
            randomOrderinBaskets2.Add(basket.GetComponent<RandomOrderinBasket>());
            //firstCol.Add(Basket);
            //ต้องรู้ว่า int ที่เท่าไหร่คือแถวที่เท่าไหร่ จากนั้นทำ List แยก 4 แถว
        }
        for (int i = 0; i < n_colLength * n_rowLength; i++)
        {
            basket = Instantiate(Basket, new Vector3(1.8f + (Xspace * (i % n_colLength)), Ystart + (Yspace * (i / n_colLength))), Quaternion.identity, ParentBasket);

            Basket.name = "Basket: " + numOfbasket++;
            randomOrderinBaskets3.Add(basket.GetComponent<RandomOrderinBasket>());
            //firstCol.Add(Basket);
            //ต้องรู้ว่า int ที่เท่าไหร่คือแถวที่เท่าไหร่ จากนั้นทำ List แยก 4 แถว
        }
        for (int i = 0; i < n_colLength * n_rowLength; i++)
        {
            basket = Instantiate(Basket, new Vector3(5.3f + (Xspace * (i % n_colLength)), Ystart + (Yspace * (i / n_colLength))), Quaternion.identity, ParentBasket);

            Basket.name = "Basket: " + numOfbasket++;
            randomOrderinBaskets4.Add(basket.GetComponent<RandomOrderinBasket>());
            //firstCol.Add(Basket);
            //ต้องรู้ว่า int ที่เท่าไหร่คือแถวที่เท่าไหร่ จากนั้นทำ List แยก 4 แถว
        }
    }

    private void Update()
    {
        //firstCol = GameObject.FindGameObjectsWithTag("Basket");
        if (ReadytoUse == true)
        {
            CheckOrderInBucket();
            
            ReadytoUse = false;
        }
        //firstCol[0] = ;
        //if (firstCol[m] == null && ReadytoAdd == false)
        /*if (Manager.instantiateManager.Scoore == 2 && ReadytoAdd == false)
        {
           AddNew();
            //AddOrderWrong();
            //ReadytoAdd = true;
        }*/
    }
    public void CheckOrderInBucket()
    {
        //int k = 5;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                //n_orderdata.Add(firstCol[j].GetComponent<RandomOrderinBasket>().orderdata[i]);
            }
            
        /*if (firstCol[0] == null && firstCol[1] == null && firstCol[2] == null)
            {
                n_orderdata.Add(firstCol[k].GetComponent<RandomOrderinBasket>().orderdata[i]);
            }
           
            //n_orderdata.Add(firstCol[1].GetComponent<RandomOrderinBasket>().orderdata[i]);
            //n_orderdata.Add(firstCol[2].GetComponent<RandomOrderinBasket>().orderdata[i]);
            //n_orderdata.Add(firstCol[3].GetComponent<RandomOrderinBasket>().orderdata[i]);
            
            /*if (ReadytoAdd == true)
            {
                n_orderdata.Add(firstCol[4].GetComponent<RandomOrderinBasket>().orderdata[i]);
                n_orderdata.Add(firstCol[5].GetComponent<RandomOrderinBasket>().orderdata[i]);
                n_orderdata.Add(firstCol[6].GetComponent<RandomOrderinBasket>().orderdata[i]);
                ReadytoAdd = false;
            }
            /*if (firstCol[0] == null && firstCol[1] == null && firstCol[2] == null)
            {
                Debug.Log("3basket = null");
                
            }*/
        }
        
        
    }

    public void AddNew()
    {
        
        for (int i = 0; i < 3; i++)
        {
            for (int m = 4; m < 8; m++)
            {
                n_orderdata.Add(firstCol[m].GetComponent<RandomOrderinBasket>().orderdata[i]);
                /*n_orderdata.Add(firstCol[m].GetComponent<RandomOrderinBasket>().orderdata[i]);
                n_orderdata.Add(firstCol[m].GetComponent<RandomOrderinBasket>().orderdata[i]);
                n_orderdata.Add(firstCol[m].GetComponent<RandomOrderinBasket>().orderdata[i]);*/
                ReadytoAdd = true;
            } 
        }
        
    }

    public void AddOrderWrong()
    {
        for (int i = 0; i < 3; i++)
        {
            
            for (int j = 0; j < firstCol.Length; j++)
            {
                if (firstCol[j].GetComponent<RandomOrderinBasket>().wrongorder.Count != 0)
                {
                    n_orderdata.Add(firstCol[j].GetComponent<RandomOrderinBasket>().wrongorder[i]);
                    Debug.Log("Wrong order Add");
                }
            }
        }
           
    }

    /*public void Addnew2()
    {
        for (int i = 0; i < 3; i++)
        {
            n_orderdata.Add(firstCol[8].GetComponent<RandomOrderinBasket>().orderdata[i]);
            n_orderdata.Add(firstCol[9].GetComponent<RandomOrderinBasket>().orderdata[i]);
            n_orderdata.Add(firstCol[10].GetComponent<RandomOrderinBasket>().orderdata[i]);
            n_orderdata.Add(firstCol[11].GetComponent<RandomOrderinBasket>().orderdata[i]);
            ReadytoAdd = false;
        }
    }*/

    public void RandomFromList()
    {
        int index = Random.Range(0, (n_orderdata.Count - 1));
        Debug.Log("RandomFromList" + index);
        Debug.Log("Random" + n_orderdata[index]);
    }
}
