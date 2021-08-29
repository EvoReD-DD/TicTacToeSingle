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
        buttonText.text = gameMode.playerChoise;
        buttonSpace.interactable = false;
        gameController.CheckWin();
    }
}
