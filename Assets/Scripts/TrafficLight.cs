using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public Sprite red;
    public Sprite yellow;
    public Sprite green;
    public IsMoving _isMoving;
    public bool isRed = true;
    public bool isGreen = false;

    private void Start()
    {
        StartCoroutine(TurnYellow(true, 2f));
    }

    public void Update()
    {
        if (_isMoving.isMoving && isRed)
        {
            Debug.Log("Explode");
        }
    }

    private IEnumerator TurnYellow(bool turnGreen, float time)
    {
        yield return new WaitForSeconds(time);
        this.GetComponent<SpriteRenderer>().sprite = yellow;
        isRed = false;
        isGreen = false;
        if (turnGreen)
        {
            StartCoroutine(TurnGreenTurnYellow());
        }
        else
        {
            StartCoroutine(TurnRedTurnYellow());
        }
    }

    private IEnumerator TurnGreenTurnYellow()
    {
        yield return new WaitForSeconds(1.25f);
        this.GetComponent<SpriteRenderer>().sprite = green;
        isGreen = true;
        StartCoroutine(TurnYellow(false, 3f));
    }

    private IEnumerator TurnRedTurnYellow()
    {
        yield return new WaitForSeconds(1);
        this.GetComponent<SpriteRenderer>().sprite = red;
        isRed = true;
        StartCoroutine(TurnYellow(true, 1.5f));
    }
}
