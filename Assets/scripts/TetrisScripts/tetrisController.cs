using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tetrisController : MonoBehaviour
{
    public static tetrisController instance;
    public float fallTime = 1.0f; //Tiempo en segundos que tarda en caer un bloque una unidad en la pantalla


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
