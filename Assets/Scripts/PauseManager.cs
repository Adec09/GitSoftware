using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public string mainMenuSceneName = "MainMenu"; // Asigna el nombre de tu escena del menú principal aquí

    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Asegúrate de que el tiempo del juego se reanude antes de cambiar de escena
        Debug.Log("Cargando escena del menú principal: " + mainMenuSceneName);
        SceneManager.LoadScene(mainMenuSceneName);
    }
}
