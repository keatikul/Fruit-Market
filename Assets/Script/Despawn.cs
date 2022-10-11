using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public string nameoftrigger = "istrigger";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        GenFruit.instantiateGenFruit.RandomMatterialFruit();
    }
}
