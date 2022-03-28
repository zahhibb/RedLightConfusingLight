using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float deathMenuAppearTime = 1f;

    public PlayerController player;
    public Transform DeathMenuCanvas;
    public Transform pauseCanvas;
    public TrafficLight trafficLight;

    public bool pauseGame = false;

    void Update()
    {
        if (trafficLight.isRed && (player._currentHorizontalSpeed > 0.5 || player._currentHorizontalSpeed < -0.5 || player._currentVerticalSpeed > 0.5 || player._currentVerticalSpeed < -0.5))
            {
                player.KillPlayer();
                StartCoroutine(DeathMenu());
            }

        if (Input.GetKeyDown(KeyCode.Escape))
        {            
            pauseGame = !pauseGame;
            pauseCanvas.gameObject.SetActive(pauseGame);
        }
    }

    IEnumerator DeathMenu()
    {
        yield return new WaitForSeconds(deathMenuAppearTime);
        DeathMenuCanvas.gameObject.SetActive(true);
    }
}
