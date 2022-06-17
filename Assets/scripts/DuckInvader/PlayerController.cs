using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] GameController game;
    public Vector3 pos;
    public bool alive = true;
    public int vida = 3;

    void Update()
    {
        if (alive && game.amountEnemy > 0)
        {
            pos = transform.position;

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0f, 0f), Space.World);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0), Space.World);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector3(0, moveSpeed * Time.deltaTime, 0), Space.World);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0, -moveSpeed * Time.deltaTime, 0), Space.World);
            }
            if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            }

        }
        if (vida == 0)
        {
            alive = false;
            Time.timeScale = 0;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyBullet>())
        {
            vida -= 1;
        }
    }
}
