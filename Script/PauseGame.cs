using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool GameisPause = false;
    //public GameObject uiTutorial;
    //public GameObject buttonRoll;
    // Start is called before the first frame update
    void Start()
    {
        //Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameisPause)
        {
            //Resume();
        }else
        {
            //Pause();
        }
    }

    public void Pause()
    {
        //uiTutorial.SetActive(true);
        Time.timeScale = 0f;
        GameisPause = true;
        //buttonRoll.SetActive(false);
    }

    public void Resume()
    {
        //uiTutorial.SetActive(false);
        Time.timeScale = 1f;
        GameisPause = false;
        /*for (int i = 0; i < TurnScriptSinglePlay.instantiateTurnsingle.Players.Length; i++)
        {
            if (TurnScriptSinglePlay.instantiateTurnsingle.checkTurn1 == true && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].number == 1 && TurnScriptSinglePlay.instantiateTurnsingle.Players[i].numberboat == 1)
            {
                buttonRoll.SetActive(true);
            }
        }*/
        
    }
}
