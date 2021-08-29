using UnityEngine;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    [SerializeField] Toggle playerChange;
    [SerializeField] Dropdown gridSize;
    [SerializeField] Text playerText;
    [SerializeField] Transform gridParent;
    [SerializeField] GridLayoutGroup gridLayout;
    [SerializeField] GameObject prefabGrid;
    public GameObject[,] prefabArray;
    public string[,] symbolArray;
    
    public string playerChoise;
    int sizeGridValue;
    public int sizeValue;
    public string playerX = "X";
    public string playerO = "O";


    void Start()
    {
        playerChoise = playerX;

    }

    public void CreateGrid()
    {
        GridSize();
        for (int i = 0; i < sizeGridValue; i++)
            {
                var createdGrid = Instantiate(prefabGrid, new Vector3(0,0,0), Quaternion.identity, gridParent);
                prefabArray[i,i] = createdGrid;
            }
    }

    public void GridSize()
    {
        if (gridSize.value == 0)
            {
            sizeValue = 3;
            sizeGridValue = sizeValue*sizeValue;
            prefabArray= new GameObject[sizeValue, sizeValue];
            symbolArray = new string[sizeValue, sizeValue];
            }
        if (gridSize.value == 1)
            {
            sizeValue = 6;
            sizeGridValue = sizeValue*sizeValue;
            gridLayout.constraintCount = 6;
            gridLayout.cellSize = new Vector3(175, 175);
            prefabGrid.GetComponentInChildren<Text>().fontSize = 150;
            prefabArray = new GameObject[sizeValue, sizeValue];
            symbolArray = new string[sizeValue, sizeValue];
        }
        if (gridSize.value == 2)
            {
            sizeValue = 9;
            sizeGridValue = sizeValue*sizeValue;
            prefabGrid.GetComponentInChildren<Text>().fontSize = 100;
            gridLayout.constraintCount = 9;
            gridLayout.cellSize = new Vector3(150, 150);
            prefabArray = new GameObject[sizeValue, sizeValue];
            symbolArray = new string[sizeValue, sizeValue];
        }
        if (gridSize.value == 3)
            {
            sizeValue = 15;
            sizeGridValue = sizeValue*sizeValue;
            prefabGrid.GetComponentInChildren<Text>().fontSize = 60;
            gridLayout.constraintCount = 15;
            gridLayout.cellSize = new Vector3(68, 68);
            prefabArray = new GameObject[sizeValue, sizeValue];
            symbolArray = new string[sizeValue, sizeValue];
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
