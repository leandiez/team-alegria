using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameController game;
    private void Awake()
    {
        game = FindObjectOfType<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Bullet>())
        {
            game.amountEnemy -= 1;
            Destroy(gameObject);
        }
    }
}
