using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockController : MonoBehaviour
{
    bool buttonPressed = false;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
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
    }
}
