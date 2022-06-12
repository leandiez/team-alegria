using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patoController : MonoBehaviour
{

    float h, v;
    Vector3 moveDirection;
    [SerializeField] float playerSpeed = 5;

    void Update()
    {
        //Traigo de los ejes para evitar hardcodear A y D, esto se configura en Edit -> Project Settings -> Input Manager
        h = Input.GetAxis("Horizontal");
        //v = Input.GetAxis("Vertical");
        moveDirection.x = h;
        //moveDirection.y = v;
        transform.position += moveDirection * Time.deltaTime * playerSpeed; //Movedirection es [-1,1] segun los ejes, deltaTime es un normalizador del tiempo entre frames, playerSpeed define la velocidad maxima y aceleracion.

        if (Input.GetButtonDown("Fire1"))
        {
            uiController.instance.LoadDialog("Muajaja Soy un Pato Diabolico");
        }
    }
}
