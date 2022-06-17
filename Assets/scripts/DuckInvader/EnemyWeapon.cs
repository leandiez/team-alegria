using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    [SerializeField] EnemyBullet bala;
    [SerializeField] float shootingSpeed;
    [SerializeField] PlayerController player;

    private void Awake()
    {
        player = FindObjectOfType<PlayerController>();
    }
    void Update()
    {
        if(Time.time > 2 && player.alive)
        {
            if (Random.Range(0, 10000) < shootingSpeed)
            {
                Instantiate(bala, transform.position, transform.rotation);
            }
        }
        Vector2 target = player.pos;
        Vector2 current = transform.position;
        var direction = target - current;
        var angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) +90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        
    }
}
