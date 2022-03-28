using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBlock : MonoBehaviour
{
    public TrafficLight light;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (light.isGreen || light.isRed)
        {
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(RestoreBox());
        }
    }

    private IEnumerator RestoreBox()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Collider2D>().enabled = true;
        GetComponent<SpriteRenderer>().enabled = true;
    }
}
