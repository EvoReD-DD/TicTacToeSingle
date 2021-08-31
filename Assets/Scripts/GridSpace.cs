using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
[SerializeField] GameController gameController;
[SerializeField] GameMode gameMode;
[SerializeField] Button buttonSpace;
[SerializeField] Text buttonText;
public void SetSpace()
{
    bool nextTurn=false;
    buttonText.text = gameMode.PlayerChoise;
    buttonSpace.interactable = false;
    nextTurn = gameController.CheckWin(gameMode.PlayerChoise,gameMode.SizeValue);
    if (nextTurn)
    {
        gameController.NextTurnAI();
           
    }
        
}
}
