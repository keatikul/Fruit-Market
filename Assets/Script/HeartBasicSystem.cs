using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBasicSystem : MonoBehaviour
{
    public GameObject[] Heart;
    public static HeartBasicSystem heartBasic;
    public GameObject GameOverCanvas;

    private void Start()
    {
        MakeSingleton();
    }
    public void MakeSingleton()
    {
        if (heartBasic == null)
        {
            heartBasic = this;
        }
    }
    public void Damage()
    {
        for (int i = 0; i > 2; i++)
        {
            if (Heart.Length == 3)
            {
                Destroy(Heart[i]);
            }
            if (Heart.Length == 2)
            {
                Destroy(Heart[i]);
            }
            if (Heart.Length == 1)
            {
                Destroy(Heart[i]);
            }

            if (Heart.Length == 0)
            {
                GameOverCanvas.SetActive(true);
            }
        }
        
    }
}
