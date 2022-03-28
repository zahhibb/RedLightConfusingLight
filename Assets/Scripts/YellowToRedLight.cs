using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowToRedLight : MonoBehaviour
{
    public GameObject RedLightPrefab;
    Vector2 Position = new Vector2(7, 1);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TurnRed());
    }
    private IEnumerator TurnRed()
    {
        yield return new WaitForSeconds(1);
        Instantiate(RedLightPrefab, Position, Quaternion.identity);
        Destroy(gameObject);
    }
}
