using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public bool onGroundLeft;
    public bool onGroundRight;

    private float rayLength;

    private Rigidbody2D m_Rigidbody;
    private float jumpSpeed;

    public LayerMask groundLayer;

    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        rayLength = 1f;

        m_Rigidbody = GetComponent<Rigidbody2D>();
        jumpSpeed = 5f;

        offset = 0.375f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position + new Vector3(-offset, 0f, 0f), Vector2.down, Color.red);
        Debug.DrawRay(transform.position + new Vector3(offset, 0f, 0f), Vector2.down, Color.green);
        
        onGroundLeft = Physics2D.Raycast(transform.position + new Vector3(-offset, 0f, 0f), Vector2.down, rayLength, groundLayer);
        onGroundRight = Physics2D.Raycast(transform.position + new Vector3(offset, 0f, 0f), Vector2.down, rayLength, groundLayer);
        
        if (onGroundLeft || onGroundRight)
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
