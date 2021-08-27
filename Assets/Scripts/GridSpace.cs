using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    public GameObject gameController;
    public GameObject gameMode;
    public Button buttonSpace;
    public Text buttonText;
    public void SetSpace()
    {
        buttonText.text = gameMode.GetComponent<GameMode>().playerChoise;
        buttonSpace.interactable = false;
        gameController.GetComponent<GameController>().CheckWin();
    }
}
