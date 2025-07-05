using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public string mainMenuSceneName = "MainMenu"; // Asigna el nombre de tu escena del men� principal aqu�

    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Aseg�rate de que el tiempo del juego se reanude antes de cambiar de escena
        Debug.Log("Cargando escena del men� principal: " + mainMenuSceneName);
        SceneManager.LoadScene(mainMenuSceneName);
    }
}
