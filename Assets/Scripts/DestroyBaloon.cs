using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBaloon : MonoBehaviour
{
    private new GameObject gameObject;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameObject = GameObject.FindGameObjectWithTag("Player");
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            gameManager.GameOver();

        }
    }
    
}
