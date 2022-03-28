using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsMoving : MonoBehaviour
{
    public PlayerController player;
    public bool isMoving = false;
 
    private void Update()
    {
        if (player.Velocity == Vector3.zero)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }
    }
}
