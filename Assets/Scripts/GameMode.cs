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
    [SerializeField] Toggle modeChoiceButton;
    [SerializeField] Text modeChoice;
    [SerializeField] GameObject[,] prefabButtonsArray;
    [SerializeField] GameObject prefab3DGrid;
    [SerializeField] Transform prefabFloorGridParent;
    [SerializeField] GameObject playerXPrefab3D;
    [SerializeField] GameObject playerOPrefab3D;
    private bool mode3DGame;
    private GameObject[,] prefabArray;
    private GameObject playerXChoise3D;
    private GameObject playerOChoise3D;
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
                if (mode3DGame == false)
                {
                    var createdGrid = Instantiate(prefabGrid, new Vector3(0, 0, 0), Quaternion.identity, gridParent);
                    prefabArray[i, y] = createdGrid;
                }
                else {
                    var createPrefabGrid = Instantiate(prefab3DGrid, prefabFloorGridParent.position, Quaternion.identity, prefabFloorGridParent);
                    createPrefabGrid.transform.localScale =new Vector3(0.6f,0.6f,0.6f);
                    prefabButtonsArray[i, y] = createPrefabGrid;
                }
            }
        }
    }

    public void GridSize()
    {
        if (gridSize.value == 0)
        {
            sizeValue = 3;
            sizeGridValue = sizeValue * sizeValue;
            if (mode3DGame == false)
            {
                prefabArray = new GameObject[sizeValue, sizeValue];
            }
            else
            {
                prefabButtonsArray = new GameObject[sizeValue, sizeValue];
            }

        }
        if (gridSize.value == 1)
        {
            sizeValue = 6;
            sizeGridValue = sizeValue * sizeValue;
            gridLayout.constraintCount = 6;
            if (mode3DGame == false)
            {
                gridLayout.cellSize = new Vector3(175, 175);
                prefabGrid.GetComponentInChildren<Text>().fontSize = 150;
                prefabArray = new GameObject[sizeValue, sizeValue];
            }
            else
            {
                prefabButtonsArray = new GameObject[sizeValue, sizeValue];
            }
        }
        if (gridSize.value == 2)
        {
            sizeValue = 9;
            sizeGridValue = sizeValue * sizeValue;
            gridLayout.constraintCount = 9;
            if (mode3DGame == false)
            {
                prefabGrid.GetComponentInChildren<Text>().fontSize = 100;
                gridLayout.cellSize = new Vector3(150, 150);
                prefabArray = new GameObject[sizeValue, sizeValue];
            }
            else
            {
                prefabButtonsArray = new GameObject[sizeValue, sizeValue];
            }
        }
        if (gridSize.value == 3)
        {
            sizeValue = 15;
            sizeGridValue = sizeValue * sizeValue;
            gridLayout.constraintCount = 15;
            if (mode3DGame == false)
            {
                prefabArray = new GameObject[sizeValue, sizeValue];
                prefabGrid.GetComponentInChildren<Text>().fontSize = 60;
                gridLayout.cellSize = new Vector3(68, 68);
            }
            else
            {
                prefabButtonsArray = new GameObject[sizeValue, sizeValue];
            }
        }
    }
    
    public void PlayerChoose()
    {
        if (playerChange.isOn)
        {
            playerText.text = playerX;
            playerChoise = playerX;
            playerXChoise3D = playerXPrefab3D;

        }
        else
        {
            playerText.text = playerO;
            playerChoise = playerO;
            playerOChoise3D = playerOPrefab3D;
        }
    }
    public void ModeChoice()
    {
        if (modeChoiceButton.isOn)
        {
            mode3DGame = false;
            modeChoice.text = "2D";
        }
        else
        {
            mode3DGame = true;
            modeChoice.text = "3D";
        }
    }
    public GameObject PlayerXChoise3D
    {
        get { return playerXChoise3D; }
    }
    public bool Mode3DGame
    {
        get { return mode3DGame; }
    }
    public GameObject[,] PrefabArray
    {
        get { return prefabArray; }

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