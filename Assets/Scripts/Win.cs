using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public Transform canvas;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        canvas.gameObject.SetActive(true);
    }
}
