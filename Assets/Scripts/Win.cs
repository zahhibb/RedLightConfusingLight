using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public Transform text;

    private bool hasWon = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hasWon = true;
        }
    }

    void Update()
    {
        if (hasWon)
        {
            text.gameObject.SetActive(true);
        }
    }
}
