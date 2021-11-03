using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public GameObject titleScreen;
    public Button restartButton;
    public Button gameOverButton;
    private AudioSource gameMusic;
    public AudioSource gameOverMusic;
    // Start is called before the first frame update
    void Start()
    {
        gameMusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverButton.gameObject.SetActive(true);
        isGameActive = false;
        gameMusic.Pause();
        gameOverMusic.Play(0);

    }

}
