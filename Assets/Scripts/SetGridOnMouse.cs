using UnityEngine;

public class SetGridOnMouse : MonoBehaviour
{
    [SerializeField] GameController gameController;
    [SerializeField] GameMode gameMode;
    private void OnMouseDown()
    {
        Instantiate(gameMode.PlayerXChoise3D, this.transform.position, this.transform.rotation);
        //Destroy(OldPref);
    }
}
