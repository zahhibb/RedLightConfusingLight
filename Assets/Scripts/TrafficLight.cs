using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public Sprite red;
    public Sprite yellow;
    public Sprite green;
    public IsMoving _isMoving;
    bool isRed = true;

    private void Start()
    {
        StartCoroutine(TurnYellow(true));
    }

    public void Update()
    {
        if (_isMoving.isMoving && isRed)
        {
            Debug.Log("Explode");
        }
    }

    private IEnumerator TurnYellow(bool turnGreen)
    {
        yield return new WaitForSeconds(5);
        this.GetComponent<SpriteRenderer>().sprite = yellow;
        isRed = false;
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
        yield return new WaitForSeconds(1);
        this.GetComponent<SpriteRenderer>().sprite = green;
        StartCoroutine(TurnYellow(false));
    }

    private IEnumerator TurnRedTurnYellow()
    {
        yield return new WaitForSeconds(1);
        this.GetComponent<SpriteRenderer>().sprite = red;
        isRed = true;
        StartCoroutine(TurnYellow(true));
    }
}
