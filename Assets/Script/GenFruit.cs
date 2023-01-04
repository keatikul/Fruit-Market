using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenFruit : MonoBehaviour
{
    public GameObject[] fruit;
    public Sprite[] spritesFruitArray;
    public GameObject fruitSpawn;
    public int index;
    public int n_index;
    public int matt;
    public static GenFruit instantiateGenFruit;
    //public Material[] materials;
    //Renderer rend;
    public GameObject fruitt;
    public SpriteRenderer spr;
    public bool Readytogen = false;
    public bool ReadytoAdd = false;
    public int a = 0;
    public int numoforder;

    public List<int> orderleft = new List<int>();
    

    
    private void Start()
    {
        
        MakeSingleton();
        //RandomMatterialFruit();
        //rend.GetComponent<Renderer>();
        //rend.enabled = true;
        //rend.sharedMaterial = materials[index -1];
        //RandomFruit();
        //Readytogen = true;
        //Debug.Log("Readytogen: " + Readytogen);
        //ReadytoAdd = true;
        //Debug.Log("Readytoadd: " + ReadytoAdd);

    }

    public void MakeSingleton()
    {
        if (instantiateGenFruit == null)
        {
            instantiateGenFruit = this;
        }
    }

    private void Update()
    {

        //rend.sharedMaterial = materials[index-1];
        //matt = index;
        //RandomFruit();
        if (ReadytoAdd == true)
        {
            CheckOrderdata();
        }
        if (Readytogen == true)
        {
            
            RandomMatterialFruit();
            
        }
        
    }

    /*public void NewRandom()
    {
        if (Shooting.instantiateShooting.isShooting == true)
        {
            RandomMatterialFruit();
            Shooting.instantiateShooting.isShooting = false;
            FindFruitSpawn();
        }
    }*/

    /*public void FindFruitSpawn()
    {
        if (fruitSpawn == null)
        {
            fruitSpawn = GameObject.FindGameObjectWithTag("Fruit Spawn");
            RandomMatterialFruit();
        }
    }*/

    
    public void RandomMatterialFruit()
    {
        //CheckOrderdata();
        if (orderleft.Count != 0)
        {
            //เหลือตัวเดียวไม่ต้อง Random
            if (orderleft.Count == 1)
            {
                Debug.Log("Ontothis");
                this.index = orderleft[0];
            }
            if(orderleft.Count > 1)
            {
                n_index = Random.Range(0, orderleft.Count - 1);
                index = orderleft[n_index];
                //orderleft.RemoveAt(n_index);
                Debug.Log("Gen");
            }
            
            //Debug.Log("index" + index);
            //Debug.Log("n_index" + n_index);
            //orderleft.RemoveAt(n_index);
            //numoforder = Random.Range(0, 4);
            /*if (a >= 3)
            {
                a = 0;
            }
            /*if (numoforder == 0)
            {
                
                //n_index = Random.Range(0, (GenBasket.genBasket.randomOrderinBaskets[0].orderdata.Count - 1));
                //index = GenBasket.genBasket.randomOrderinBaskets[0].orderdata[a];
            }
            if (numoforder == 1)
            {
                //n_index = Random.Range(0, (GenBasket.genBasket.randomOrderinBaskets2[0].orderdata.Count - 1));
                //index = GenBasket.genBasket.randomOrderinBaskets2[0].orderdata[a];
            }
            if (numoforder == 2)
            {
                //n_index = Random.Range(0, (GenBasket.genBasket.randomOrderinBaskets3[0].orderdata.Count - 1));
                //index = GenBasket.genBasket.randomOrderinBaskets3[0].orderdata[a];
            }
            if (numoforder == 3)
            {
                //n_index = Random.Range(0, (GenBasket.genBasket.randomOrderinBaskets4[0].orderdata.Count - 1));
                //index = GenBasket.genBasket.randomOrderinBaskets4[0].orderdata[a];
            }*/
            //a += 1;
            //GenBasket.genBasket.n_orderdata.RemoveAt(n_index);

            RandomFruit();
            Readytogen = false;
        }
    }

    

    //สร้างฟังก์ชันเพิ่มเช็ค 3 อย่าง orderdata อันไหนเป็น 0 ไปแล้วบ้าง ถ้ามันเหลือ 1 อันก็ไม่ต้อง Random ทำฟังก์ชันของแถวที่ 0 4ตัวออกมา loop 

    public void CheckOrderdata()
    {
        /*.Log("Check orderdata");
        Debug.Log("A: " + a);
        Debug.Log("GenBasket: "+ GenBasket.genBasket.randomOrderinBaskets[a]);*/
        orderleft.Clear();
        for (int j = 0; j < 3; j++)
        {
            if (GenBasket.genBasket.randomOrderinBaskets[a].orderdata[j] != 0)
            {
                orderleft.Add(GenBasket.genBasket.randomOrderinBaskets[a].orderdata[j]);
            }
            if (GenBasket.genBasket.randomOrderinBaskets2[a].orderdata[j] != 0)
            {
                orderleft.Add(GenBasket.genBasket.randomOrderinBaskets2[a].orderdata[j]);
            }
            if (GenBasket.genBasket.randomOrderinBaskets3[a].orderdata[j] != 0)
            {
                orderleft.Add(GenBasket.genBasket.randomOrderinBaskets3[a].orderdata[j]);
            }
            if (GenBasket.genBasket.randomOrderinBaskets4[a].orderdata[j] != 0)
            {
                orderleft.Add(GenBasket.genBasket.randomOrderinBaskets4[a].orderdata[j]);
            }
            
        }
        
        //for (int k = 0; k < 3; k++)
        if (orderleft.Count == 0)
        //if (GenBasket.genBasket.randomOrderinBaskets[0].orderdata[k] == 0 && GenBasket.genBasket.randomOrderinBaskets2[0].orderdata[k] == 0 && GenBasket.genBasket.randomOrderinBaskets3[0].orderdata[k] == 0 && GenBasket.genBasket.randomOrderinBaskets4[0].orderdata[k] == 0)
        {
            a += 1;
            CheckOrderdata();
        }

        ReadytoAdd = false;






        /*if (GenBasket.genBasket.randomOrderinBaskets[0].orderdata.Count != 0)
        {
            /*n_index = Random.Range(0, (GenBasket.genBasket.randomOrderinBaskets[0].orderdata.Count));
            index = GenBasket.genBasket.randomOrderinBaskets[0].orderdata[n_index];
            Debug.Log(index);
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (GenBasket.genBasket.randomOrderinBaskets[i].orderdata.Count == 1)
                {

                }
                else
                {
                    
                }
                if (GenBasket.genBasket.randomOrderinBaskets[i].orderdata[j] != 0)
                {

                }
            }
            
        }*/
    }

    public void ClearValue()
    {
        orderleft.Clear();
    }

    

    public void RandomFruit()
    {
        if (index == 1)
        {
            spr.sprite = spritesFruitArray[0];
            fruitt.name = "1";
            Instantiate(fruitt, new Vector3(0,-13.5f,0), Quaternion.identity);
        }
        if (index == 2)
        {
            spr.sprite = spritesFruitArray[1];
            fruitt.name = "2";
            Instantiate(fruitt, new Vector3(0, -13.5f, 0), Quaternion.identity);
        }
        if (index == 3)
        {
            spr.sprite = spritesFruitArray[2];
            fruitt.name = "3";
            Instantiate(fruitt, new Vector3(0, -13.5f, 0), Quaternion.identity);
        }
        if (index == 4)
        {
            spr.sprite = spritesFruitArray[3];
            fruitt.name = "4";
            Instantiate(fruitt, new Vector3(0, -13.5f, 0), Quaternion.identity);
        }
        if (index == 5)
        {
            spr.sprite = spritesFruitArray[4];
            fruitt.name = "5";
            Instantiate(fruitt, new Vector3(0, -13.5f, 0), Quaternion.identity);
        }
    }
}
