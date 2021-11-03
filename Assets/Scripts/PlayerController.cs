using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    Rigidbody2D rb2d;
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(Vector2.up * 50, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (rb2d.position.y < -14)
        {
            rb2d.position = new Vector2(transform.position.x, -14);
        }

        if (CrossPlatformInputManager.GetButton("Jump"))
        {
            rb2d.AddForce(Vector2.up * 2750);
        }
        horizontalInput = CrossPlatformInputManager.GetAxis("Horizontal");
        rb2d.velocity = horizontalInput * 35 * Vector2.right;
    }
}
