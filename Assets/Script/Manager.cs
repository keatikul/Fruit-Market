using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int Scoore;
    public Text Text_Score;
    public Text OV_Score;
    public Text P_Score;
    public Text High_Score;
    public static Manager instantiateManager;
    public int shootcount;
    public float timeValue;
    private bool Moving;
    public GameObject BasketParents;
    public float audioData;
    public int ScoreCount;
    public int BasketMove;
    public bool alreadyCreate = false;
    

    private void Start()
    {
        MakeSinglton();
        audioData = PlayerPrefs.GetFloat("Mute");
        Debug.Log("audio"+audioData);
        High_Score.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
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
        Text_Score.text = ""+Scoore.ToString();
        OV_Score.text = "" + Scoore.ToString();
        P_Score.text = "" + Scoore.ToString();
        TimeCount();
        ScoreCount = Scoore % 8;
        //if (GenBasket.genBasket.randomOrderinBaskets[4] == null && GenBasket.genBasket.randomOrderinBaskets2[4] == null && GenBasket.genBasket.randomOrderinBaskets3[4] == null && GenBasket.genBasket.randomOrderinBaskets4[4] == null && alreadyCreate == false)
        if (Scoore % 4 == 0 && alreadyCreate == false && BasketMove == 3)
        {
            //ขยับทีละ 3 แล้วเจนใหม่
            //GenBasket.genBasket.CreateNew();
            alreadyCreate = true;
            Debug.Log("Create New");
        }
        if (BasketMove == 3)
        {
            GenBasket.genBasket.CreateNew();
            BasketMove = 0;
        }
        if (Scoore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Scoore);
            High_Score.text = Scoore.ToString();
        }
        /*if (Shooting.instantiateShooting.isShooting == true)
        {
            shootcount++;
            Shooting.instantiateShooting.isShooting = false;
        }*/
    }

    public void TimeCount()
    {
        if (timeValue < 5)
        {
            timeValue += Time.deltaTime;
        }
        else
        {
            Moving = true;
            BasketParents.transform.localPosition = new Vector3(transform.position.x, BasketParents.transform.position.y - 1.00f, transform.position.z);
            timeValue = 0;
            BasketMove++;
        }

        /*if (Moving == true)
        {
            
            Moving = false;
            //GenBasket.genBasket.CreateNew();
        }*/
    }


}
