using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    
    public string playerChoise;
    string playerX = "X";
    string playerO = "O";
    public Toggle modeChange;
    public Toggle playerChange;
    public Text modeText;
    public Text playerText;
    
     void Start()
    {
        playerChoise = playerX;
    }

   
    public void PlayerChoose()
    {
        if (playerChange.isOn)
        {
            playerText.text = playerX;
            playerChoise = playerX;
            
        }
        else
        {
            playerText.text = playerO;
            playerChoise = playerO;
            
        }
    }
}
