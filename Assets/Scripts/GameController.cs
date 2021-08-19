using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text[] buttonTextList;
    private string playerChoiseSide;
    public GameObject restart;
    public GameObject gameMode;
    public GameObject gridSpace;
    public int count;

    public void PlayerChooseReference()
    {
        playerChoiseSide = gameMode.GetComponent<GameMode>().playerChoise;
        
    }

    public void CheckWin()
    {
        PlayerChooseReference();
            if (buttonTextList[0].text == playerChoiseSide && buttonTextList[1].text == playerChoiseSide && buttonTextList[2].text == playerChoiseSide)
            {
                GameOver();
            }
            if (buttonTextList[3].text == playerChoiseSide && buttonTextList[4].text == playerChoiseSide && buttonTextList[5].text == playerChoiseSide)
            {
                GameOver();
            }
            if (buttonTextList[6].text == playerChoiseSide && buttonTextList[7].text == playerChoiseSide && buttonTextList[8].text == playerChoiseSide)
            {
                GameOver();
            }
            if (buttonTextList[0].text == playerChoiseSide && buttonTextList[3].text == playerChoiseSide && buttonTextList[6].text == playerChoiseSide)
            {
                GameOver();
            }
            if (buttonTextList[1].text == playerChoiseSide && buttonTextList[4].text == playerChoiseSide && buttonTextList[7].text == playerChoiseSide)
            {
                GameOver();
            }
            if (buttonTextList[2].text == playerChoiseSide && buttonTextList[5].text == playerChoiseSide && buttonTextList[8].text == playerChoiseSide)
            {
                GameOver();
            }
            if (buttonTextList[0].text == playerChoiseSide && buttonTextList[4].text == playerChoiseSide && buttonTextList[8].text == playerChoiseSide)
            {
                GameOver();
            }
            if (buttonTextList[2].text == playerChoiseSide && buttonTextList[4].text == playerChoiseSide && buttonTextList[6].text == playerChoiseSide)
            {
                GameOver();
            }
        Debug.Log("Checkwin");
      //  NextTurnAI();
        
    }

    void NextTurnAI()
    {
        for (int i = 0; i < buttonTextList.Length && buttonTextList[i].text != playerChoiseSide; i++)
            {
            gridSpace.GetComponent<GridSpace>().buttonText.text = "O";
            count = i;
            Debug.Log("AI");
        }
    }
    void GameOver()
    {
        Debug.Log("GameOver");
    }
    
}
