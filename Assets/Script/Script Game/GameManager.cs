using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GoPanel;

    AudioSource loseSound;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        loseSound = GetComponent<AudioSource>();
    }

    public void GameOver()
    {
        loseSound.Play();

        Time.timeScale = 0;
        GoPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}