using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] float velocidadBala;
    void Update()
    {
        transform.Translate(new Vector3(0, -velocidadBala * Time.deltaTime, 0), Space.Self);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
