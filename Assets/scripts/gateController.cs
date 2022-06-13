using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gateController : MonoBehaviour
{
    bool playerIsOnGate = false;
    [SerializeField] int indexOfSceneToJump;
    private void Update()
    {
        if (playerIsOnGate && Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene(indexOfSceneToJump);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) playerIsOnGate = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) playerIsOnGate = false;
    }
}
