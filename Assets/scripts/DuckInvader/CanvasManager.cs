using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] string menu;
    [SerializeField] string invader;
    void Update()
    {
        
    }
    public void Salir()
    {
        SceneManager.LoadScene(menu);
    }
    public void Volver()
    {
        SceneManager.LoadScene(invader);
    }
}
