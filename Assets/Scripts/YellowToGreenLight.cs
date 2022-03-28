using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowToGreenLight : MonoBehaviour
{
    public GameObject GreenLightPrefab;
    Vector2 Position = new Vector2(7, 1);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TurnGreen());
    }
    private IEnumerator TurnGreen()
    {
        yield return new WaitForSeconds(1);
        Instantiate(GreenLightPrefab, Position, Quaternion.identity);
        Destroy(gameObject);
    }
}
