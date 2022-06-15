using UnityEngine;

public class GameController : MonoBehaviour
{
    public int amountEnemy = 4;
    [SerializeField] GameObject win, lose;
    [SerializeField] PlayerController player;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (amountEnemy == 0)
        {
            Time.timeScale = 0;
            win.SetActive(true);
        }
        if(player.alive == false)
        {
            lose.SetActive(true);
        }
    }
}
