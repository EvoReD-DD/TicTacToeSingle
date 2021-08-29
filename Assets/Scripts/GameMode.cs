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
    public GameObject[] prefabArray; 
    public string playerChoise;
    int sizeGridValue;
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
                prefabArray[i] = createdGrid;
            }
    }

    public void GridSize()
    {
        if (gridSize.value == 0)
            {
            sizeGridValue = 9;
            prefabArray= new GameObject[9];
            }
        if (gridSize.value == 1)
            {
            sizeGridValue = 36;
            gridLayout.constraintCount = 6;
            gridLayout.cellSize = new Vector3(175, 175);
            prefabGrid.GetComponentInChildren<Text>().fontSize = 150;
            prefabArray = new GameObject[36];
        }
        if (gridSize.value == 2)
            {
            sizeGridValue = 81;
            prefabGrid.GetComponentInChildren<Text>().fontSize = 100;
            gridLayout.constraintCount = 9;
            gridLayout.cellSize = new Vector3(150, 150);
            prefabArray = new GameObject[81];
        }
        if (gridSize.value == 3)
            {
            sizeGridValue = 225;
            prefabGrid.GetComponentInChildren<Text>().fontSize = 60;
            gridLayout.constraintCount = 15;
            gridLayout.cellSize = new Vector3(68, 68);
            prefabArray = new GameObject[225];
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
