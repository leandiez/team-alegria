using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class uiController : MonoBehaviour
{
    public static uiController instance;
    [SerializeField] GameObject retroDialogFrame;
    [SerializeField] TextMeshProUGUI textBox;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void LoadDialog(string dialog)
    {
        textBox.text = dialog;
        StartCoroutine(DisplayRetroFrame(3));

    }

    IEnumerator DisplayRetroFrame(int duration)
    {
        retroDialogFrame.SetActive(true);
        yield return new WaitForSeconds(duration);
        retroDialogFrame.SetActive(false);
    }


}
