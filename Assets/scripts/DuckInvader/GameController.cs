using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int amountEnemy = 28;
    public int amountDeath = 0;
    [SerializeField] GameObject win, lose;
    [SerializeField] PlayerController player;
    [SerializeField] GameObject cora1;
    [SerializeField] GameObject cora2;
    [SerializeField] GameObject cora3;
    [SerializeField] Text contador;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (amountEnemy == amountDeath)
        {
            Time.timeScale = 0;
            win.SetActive(true);
        }
        if(player.alive == false)
        {
            lose.SetActive(true);
        }
        contador.text = (amountDeath + " / " + amountEnemy);
        vida();

    }
    public void vida()
    {
        if (player.vida == 3)
        {
            cora1.SetActive(true);
            cora2.SetActive(true);
            cora3.SetActive(true);
        }
        else if (player.vida == 2)
        {
            cora1.SetActive(true);
            cora2.SetActive(true);
            cora3.SetActive(false);
        }
        else if (player.vida == 1)
        {
            cora1.SetActive(true);
            cora2.SetActive(false);
            cora3.SetActive(false);
        }
        else
        {
            cora1.SetActive(false);
            cora2.SetActive(false);
            cora3.SetActive(false);
        }
    }
}
