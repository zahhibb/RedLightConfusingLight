using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool playerHasDied = false;
    private float deathMenuAppearTime = 1f;

    public GameObject Player;
    public Transform DeathMenuCanvas;

    void Update()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.T))
        {
            Player.GetComponent<PlayerController>().KillPlayer();
            StartCoroutine(DeathMenu());
        }
    }

    IEnumerator DeathMenu()
    {
        yield return new WaitForSeconds(deathMenuAppearTime);
        DeathMenuCanvas.gameObject.SetActive(true);
        // DeathMenuCanvas.GetComponent<Animator>().SetBool("ShowDeathMenu", true);
    }
}
