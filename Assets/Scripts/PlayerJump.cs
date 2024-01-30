using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public bool onGround;

    private float rayLength;

    private Rigidbody2D m_Rigidbody;
    private float jumpSpeed;

    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        rayLength = 1f;

        m_Rigidbody = GetComponent<Rigidbody2D>();
        jumpSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector2.down, Color.green);
        
        onGround = Physics2D.Raycast(transform.position, Vector2.down, rayLength, groundLayer);

        if (onGround)
        {
            //Debug.Log("Hit the Ground");

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("jump");
                m_Rigidbody.AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
            }
        }
    }
}
