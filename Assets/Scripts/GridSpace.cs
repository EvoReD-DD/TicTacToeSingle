using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GridSpace : MonoBehaviour
{
    [SerializeField] GameController gameController;
    [SerializeField] GameMode gameMode;
    [SerializeField] Button buttonSpace;
    [SerializeField] GameObject buttonTextObj;
    [SerializeField] Text buttonText;
    [SerializeField] GameObject prefabX;
    [SerializeField] GameObject prefabO;
    [SerializeField] GameObject prefabSpace;



    public void SetSpace()
    {
        bool nextTurn = false;
        buttonText.text = gameMode.PlayerChoise;
        buttonSpace.interactable = false;
        if (gameMode.Mode3DGame==true)
        {
            if (gameMode.PlayerChoise == gameMode.PlayerX)
            {
                buttonTextObj.SetActive(false);
                prefabSpace.SetActive(false);
                prefabX.SetActive(true);
            }
            else if (gameMode.PlayerChoise != gameMode.PlayerX)
            {
                prefabSpace.SetActive(false);
                prefabO.SetActive(true);
            }
        }

        nextTurn = gameController.CheckWin(gameMode.PlayerChoise, gameMode.SizeValue);
        if (nextTurn)
        {
            gameController.NextTurnAI();

        }
    }
    public GameObject ButtonTextObg
    {
        get { return buttonTextObj; }
    }
    public GameObject PrefabX
    {
        get { return prefabX; }
    }
    public GameObject PrefabO
    {
        get { return prefabO; }
    }
    public GameObject PrefabSpace
    {
        get { return prefabSpace; }
    }
}
