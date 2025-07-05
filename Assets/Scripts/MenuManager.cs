using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string sceneToLoad = "GameScene";

    public GameObject optionsCanvas;

    

    public void ShowOptions()
    {
        if (optionsCanvas != null)
        {
            optionsCanvas.SetActive(true);
            Debug.Log("Activando Canvas de Opciones.");
        }
        else
        {
            Debug.LogError("El Canvas de Opciones no está asignado en el Inspector.");
        }
    }

    public void HideOptions()
    {
        if (optionsCanvas != null)
        {
            optionsCanvas.SetActive(false);
            Debug.Log("Ocultando Canvas de Opciones.");
        }
        else
        {
            Debug.LogError("El Canvas de Opciones no está asignado en el Inspector.");
        }
    }

    public void ExitGame()
    {
        Debug.Log("Saliendo del juego.");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
