using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ForeignObject : MonoBehaviour
{
    private int health;
    private int coinCount;
    private bool iFrames;
    private float iFrameTimer;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        coinCount = 0;
        iFrames = false;
        iFrameTimer = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (iFrames)
        {
            iFrameTimer -= Time.deltaTime;
            if (iFrameTimer <= 0f)
            {
                iFrames = false;
                iFrameTimer = 1.5f;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            ChangeHealth(-1);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            
        }
    }

    // My functions

    void Death()
    {
        SceneManager.LoadScene("Start");
        health = 5;
        coinCount = 0;
        iFrames = false;
        iFrameTimer = 1.5f;
    }

    void ChangeHealth(int amount)
    {
        if (!iFrames)
        {
            iFrames = true;
            health += amount;
            if (health < 1)
            {
                Death();
            }
        }
    }
}
