using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
    private float speed = 1.5f;
    private bool move = false;
    private Vector2 moveDirection;
    private void Update()
    {
        if (move)
        {
            transform.Translate(moveDirection * speed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        move = true;
        moveDirection = -Vector2.right * Time.deltaTime;
        StartCoroutine(MoveRight());
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        StopAllCoroutines();
        move = false;
    }

    private IEnumerator MoveRight()
    {
        yield return new WaitForSeconds(1);
        moveDirection *= -1f;
        StartCoroutine(MoveLeft());
    }
    
    private IEnumerator MoveLeft()
    {
        yield return new WaitForSeconds(1);
        moveDirection *= -1f;
        StartCoroutine(MoveRight());
    }
}
