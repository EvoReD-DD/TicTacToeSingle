using UnityEngine;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    [SerializeField] Toggle playerChange;
    [SerializeField] Dropdown gridSize;
    [SerializeField] Text playerText;
    [SerializeField] GameObject createdGrid;
    [SerializeField] Transform gridParent;
    static public string playerChoise;
    int sizeGridValue;
    public string playerX = "X";
    public string playerO = "O";
    int rows;
    int cols;


    void Start()
    {
        playerChoise = playerX;

    }
    public void CreateGrid()
    {
        GridSize();
        for (int i = 0; i < sizeGridValue; i++)
            {
                var clone = Instantiate(createdGrid, new Vector3(0,0,0), Quaternion.identity, gridParent);
            }
    }

    public void GridSize()
    {
        if (gridSize.value == 0)
            {
            sizeGridValue = 9;
            rows = 3;
            cols = 3;
            }
        if (gridSize.value == 1)
            {
            sizeGridValue = 36;
            rows = 6;
            cols = 6;
        }
        if (gridSize.value == 2)
            {
            sizeGridValue = 81;
            rows = 9;
            cols = 9;
        }
        if (gridSize.value == 3)
            {
            sizeGridValue = 225;
            rows = 15;
            cols = 15;
        }
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
