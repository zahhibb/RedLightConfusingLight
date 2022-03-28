using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLight : MonoBehaviour
{
    public GameObject YellowLightPrefab;
    Vector2 Position = new Vector2(7, 1);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TurnYellow());
    }
    private IEnumerator TurnYellow()
    {
        yield return new WaitForSeconds(5);
        Instantiate(YellowLightPrefab, Position, Quaternion.identity);
        Destroy(gameObject);
    }
}
