using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    public GameObject currentCanvas;
    public GameObject nextCanvas;

    void Start()
    {
        // Asegúrate de que el canvas inicial esté activo y el siguiente inactivo al inicio
        if (currentCanvas != null)
        {
            currentCanvas.SetActive(true);
        }
        if (nextCanvas != null)
        {
            nextCanvas.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) // KeyCode.Return es la tecla ENTER
        {
            SwitchCanvases();
        }
    }

    public void SwitchCanvases()
    {
        if (currentCanvas != null)
        {
            currentCanvas.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Current Canvas no asignado en CanvasSwitcher.");
        }

        if (nextCanvas != null)
        {
            nextCanvas.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Next Canvas no asignado en CanvasSwitcher.");
        }
    }
}

