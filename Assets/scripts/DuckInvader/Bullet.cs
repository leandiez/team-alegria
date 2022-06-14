using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float velocidadBala;


    void Update()
    {
        transform.Translate(new Vector3(0, velocidadBala * Time.deltaTime, 0), Space.Self);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
