using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 200f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //get rigidbody reference
    }

    private void Awake()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0f, jumpForce)); //add a vertical force to the player
        }
    }
}