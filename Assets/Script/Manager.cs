using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int Scoore;
    public Text Text_Score;
    public static Manager instantiateManager;
    public int shootcount;

    private void Start()
    {
        MakeSinglton();
    }

    void MakeSinglton()
    {
        if (instantiateManager == null)
        {
            instantiateManager = this;
        }
    }
    private void Update()
    {
        Text_Score.text = "Score: "+Scoore.ToString();
        /*if (Shooting.instantiateShooting.isShooting == true)
        {
            shootcount++;
            Shooting.instantiateShooting.isShooting = false;
        }*/
    }
    

}
