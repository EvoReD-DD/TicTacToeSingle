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
        buttonText.text = gameMode.playerChoise;
        buttonSpace.interactable = false;
        nextTurn = gameController.CheckWin(gameMode.playerChoise,gameMode.sizeValue);
        if (nextTurn)
        {
            gameController.NextTurnAI();
        }
        
    }
}
