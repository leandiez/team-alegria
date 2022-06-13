using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gateController : MonoBehaviour
{
    bool playerIsOnGate = false;
    [SerializeField] int indexOfSceneToJump;
    [SerializeField] GameObject enterSignal;
    private void Update()
    {
        if (playerIsOnGate && Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene(indexOfSceneToJump);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsOnGate = true;
            enterSignal.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsOnGate = false;
            enterSignal.SetActive(false);
        }
    }
}
