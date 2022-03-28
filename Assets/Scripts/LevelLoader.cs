using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private GameObject gameManager;
    public Animator transition;
    public float transitionTime = 1f;
    public Transform DeathMenuCanvas;

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    public void StartGame()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void QuitGame()
    {
        gameManager.GetComponent<GameManager>().pauseGame = false;
        Application.Quit();
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }

    public void Restart(){
        gameManager.GetComponent<GameManager>().pauseGame = false;
        StartCoroutine(LoadLevel(1));
        DeathMenuCanvas.gameObject.SetActive(false);
    }
}
