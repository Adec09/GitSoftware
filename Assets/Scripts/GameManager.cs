using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform spawnPoint;
    public GameObject pauseCanvas;  // Arrastra aquí tu canvas de pausa en el Inspector
    public CameraFollow cameraFollow;

    void Start()
    {
        RespawnPlayer();
    }

    public void RespawnPlayer()
    {
        GameObject newPlayer = Instantiate(playerPrefab, spawnPoint.position, Quaternion.identity);

        CharacterController cc = newPlayer.GetComponent<CharacterController>();
        if (cc != null)
        {
            cc.pauseCanvas = pauseCanvas;  // Aquí asignas el canvas de pausa al jugador
        }

        if (cameraFollow != null)
        {
            cameraFollow.target = newPlayer.transform;  // Que la cámara siga al nuevo jugador
        }
    }
}
