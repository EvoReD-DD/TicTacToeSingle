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
    private GameObject[,] prefabArray;
    private string[,] symbolArray;
    private string playerChoise;
    private int sizeGridValue;
    private int sizeValue;
    private string playerX = "X";
    private string playerO = "O";


    void Start()
    {
        playerChoise = playerX;

    }

    public void CreateGrid()
    {
        GridSize();
        for (int i = 0; i < sizeValue; i++)
        {
            for (int y = 0; y < sizeValue; y++)
            {
                var createdGrid = Instantiate(prefabGrid, new Vector3(0, 0, 0), Quaternion.identity, gridParent);
                prefabArray[i, y] = createdGrid;
            }
        }
    }

    public void GridSize()
    {
        if (gridSize.value == 0)
        {
            sizeValue = 3;
            sizeGridValue = sizeValue * sizeValue;
            prefabArray = new GameObject[sizeValue, sizeValue];
            symbolArray = new string[sizeValue, sizeValue];
        }
        if (gridSize.value == 1)
        {
            sizeValue = 6;
            sizeGridValue = sizeValue * sizeValue;
            gridLayout.constraintCount = 6;
            gridLayout.cellSize = new Vector3(175, 175);
            prefabGrid.GetComponentInChildren<Text>().fontSize = 150;
            prefabArray = new GameObject[sizeValue, sizeValue];
            symbolArray = new string[sizeValue, sizeValue];
        }
        if (gridSize.value == 2)
        {
            sizeValue = 9;
            sizeGridValue = sizeValue * sizeValue;
            prefabGrid.GetComponentInChildren<Text>().fontSize = 100;
            gridLayout.constraintCount = 9;
            gridLayout.cellSize = new Vector3(150, 150);
            prefabArray = new GameObject[sizeValue, sizeValue];
            symbolArray = new string[sizeValue, sizeValue];
        }
        if (gridSize.value == 3)
        {
            sizeValue = 15;
            sizeGridValue = sizeValue * sizeValue;
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
    public GameObject[,] PrefabArray
    {
        get{ return prefabArray; }
        
    }
    public string[,] SymbolArray
    {
        get { return symbolArray; }

    }
    public string PlayerChoise
    {
        get { return playerChoise; }

    }
    public int SizeGridValue
    {
        get { return sizeGridValue; }

    }
    public int SizeValue
    {
        get { return sizeValue; }
    }
    public string PlayerX
    {
        get { return playerX; }
    }
    public string PlayerO
    {
        get { return playerO; }
    }
}