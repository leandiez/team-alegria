using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] Bullet bala;
    [SerializeField] float fireRate = 0.5f;
    float nextFire = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            disparo();
        }
    }
    void disparo()
    {
        Instantiate(bala, transform.position, transform.rotation);

    }
}
