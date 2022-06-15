using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    [SerializeField] EnemyBullet bala;
    [SerializeField] float shootingSpeed;
    [SerializeField] GameObject player;

    private void Awake()
    {
        Debug.Log(this.gameObject.name + " " + player.transform.position);
    }
    void Update()
    {
        Vector2 target = player.transform.position;
        Vector2 current = transform.position;
        var direction = target - current;
        var angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) +90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        if ((Random.Range(0, 5000)* Time.deltaTime) < (shootingSpeed * Time.deltaTime))
        {
            Instantiate(bala, transform.position, transform.rotation);
        }
    }
}
