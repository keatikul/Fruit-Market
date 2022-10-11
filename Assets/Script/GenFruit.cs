using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenFruit : MonoBehaviour
{
    public GameObject[] fruit;
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

    
    private void Start()
    {
        MakeSingleton();
        //RandomMatterialFruit();
        //rend.GetComponent<Renderer>();
        //rend.enabled = true;
        //rend.sharedMaterial = materials[index -1];
        //RandomFruit();
        Readytogen = true;
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

        if (Readytogen == true)
        {
            RandomMatterialFruit();
        }
    }

    public void NewRandom()
    {
        if (Shooting.instantiateShooting.isShooting == true)
        {
            RandomMatterialFruit();
            Shooting.instantiateShooting.isShooting = false;
            FindFruitSpawn();
        }
    }

    public void FindFruitSpawn()
    {
        if (fruitSpawn == null)
        {
            fruitSpawn = GameObject.FindGameObjectWithTag("Fruit Spawn");
            RandomMatterialFruit();
        }
    }

    public void RandomMatterialFruit()
    {
        if (GenBasket.genBasket.n_orderdata.Count != 0)
        {
            n_index = Random.Range(0, (GenBasket.genBasket.n_orderdata.Count - 1));
            index = GenBasket.genBasket.n_orderdata[n_index];
            GenBasket.genBasket.n_orderdata.RemoveAt(n_index);
            RandomFruit();
            Readytogen = false;
        }
        
    }

    public void RandomFruit()
    {
        if (index == 1)
        {
            spr.color = Color.red;
            fruitt.name = "1";
            Instantiate(fruitt, new Vector3(0,-13.5f,0), Quaternion.identity);
        }
        if (index == 2)
        {
            spr.color = Color.blue;
            fruitt.name = "2";
            Instantiate(fruitt, new Vector3(0, -13.5f, 0), Quaternion.identity);
        }
        if (index == 3)
        {
            spr.color = Color.green;
            fruitt.name = "3";
            Instantiate(fruitt, new Vector3(0, -13.5f, 0), Quaternion.identity);
        }
        if (index == 4)
        {
            spr.color = Color.yellow;
            fruitt.name = "4";
            Instantiate(fruitt, new Vector3(0, -13.5f, 0), Quaternion.identity);
        }
        if (index == 5)
        {
            spr.color = Color.magenta;
            fruitt.name = "5";
            Instantiate(fruitt, new Vector3(0, -13.5f, 0), Quaternion.identity);
        }
    }
}
