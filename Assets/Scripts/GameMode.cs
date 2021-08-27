using UnityEngine;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    
    static public string playerChoise;
    public string playerX = "X";
    public string playerO = "O";
    [SerializeField] Toggle playerChange;
    [SerializeField] Text playerText;
    
     void Start()
    {
        playerChoise = playerX;
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
