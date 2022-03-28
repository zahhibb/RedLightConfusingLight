using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    float randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(2, 4);
        StartCoroutine(Disappear());
    }

    private IEnumerator Disappear()
    {
        yield return new WaitForSeconds(randomNumber);
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        StartCoroutine(Appear());
    }

    private IEnumerator Appear()
    {
        yield return new WaitForSeconds(randomNumber);
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<Collider2D>().enabled = true;
        StartCoroutine(Disappear());
    }
}
