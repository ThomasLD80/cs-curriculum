using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ForeignObject : MonoBehaviour
{
    HUD hud;
    
    private bool iFrames;
    private float iFrameTimer;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        iFrames = false;
        iFrameTimer = 0.5f;
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
                iFrameTimer = 0.5f;
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
            hud.destroyedObjects.Add(other.gameObject.GetInstanceID());
            print(hud.destroyedObjects);
            other.gameObject.SetActive(false);
            hud.coinCount += 1;
        }
    }

    // My functions

    void Death()
    {
        SceneManager.LoadScene("Start");
        hud.health = 5;
        hud.coinCount = 0;
        iFrames = false;
        iFrameTimer = 0.5f;
    }

    void ChangeHealth(int amount)
    {
        if (!iFrames)
        {
            iFrames = true;
            hud.health += amount;
            if (hud.health < 1)
            {
                Death();
            }
        }
    }
}
