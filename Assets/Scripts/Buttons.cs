using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    // Start is called before the first frame update

    public void StartButton(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

}
