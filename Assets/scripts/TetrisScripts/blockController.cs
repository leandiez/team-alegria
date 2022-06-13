using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockController : MonoBehaviour
{
    bool buttonPressed = false;
    float passedTime = 0.0f;
    void Start()
    {

    }

    void Update()
    {
        passedTime += Time.deltaTime;
        if (Input.GetAxis("Horizontal") > 0 && !buttonPressed)
        {
            gameObject.transform.position += new Vector3(1, 0, 0);
            buttonPressed = true;
        }
        else if (Input.GetAxis("Horizontal") < 0 && !buttonPressed)
        {
            gameObject.transform.position -= new Vector3(1, 0, 0);
            buttonPressed = true;
        }
        else if (Input.GetAxis("Horizontal") == 0)
        {
            buttonPressed = false;
        }

        if (passedTime >= tetrisController.instance.fallTime)
        {
            gameObject.transform.position += new Vector3(0, -1, 0);
            passedTime = 0.0f;
        }
    }
}
