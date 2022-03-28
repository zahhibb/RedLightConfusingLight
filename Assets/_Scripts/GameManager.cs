using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float deathMenuAppearTime = 1f;

    public PlayerController player;
    public Transform DeathMenuCanvas;
    public TrafficLight trafficLight;

    void Update()
    {
        if (player.Velocity != Vector3.zero && trafficLight.isRed)
        {
            player.KillPlayer();
            StartCoroutine(DeathMenu());
        }
    }

    IEnumerator DeathMenu()
    {
        yield return new WaitForSeconds(deathMenuAppearTime);
        DeathMenuCanvas.gameObject.SetActive(true);
    }
}
