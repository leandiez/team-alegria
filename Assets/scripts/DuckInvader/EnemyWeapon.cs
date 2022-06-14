using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    [SerializeField] EnemyBullet bala;
    [SerializeField] int shootingSpeed;
    [SerializeField] GameObject player;

    void Update()
    {
        Vector2 target = player.transform.position;
        Vector2 current = transform.position;
        var direction = target - current;
        var angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) +90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        float f = shootingSpeed * Time.deltaTime;
        Debug.Log(f);
        //if (Random.Range(0, 500) < shootingSpeed * Time.deltaTime)
        //{
        //    Instantiate(bala, transform.position, transform.rotation);
        //}
    }
}
