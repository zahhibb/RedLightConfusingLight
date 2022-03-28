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
            Destroy(gameObject);
        }
    }
}
