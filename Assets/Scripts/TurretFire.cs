using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour
{
    public GameObject fireball;
    public Transform target;

    private float targetX;
    private float targetY;

    private float fireAngle;
    // Start is called before the first frame update
    void Start()
    {
        target = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            targetX = target.position.x;
            targetY = target.position.y;
            fireAngle = targetY / targetX;
            
            Instantiate(fireball, transform.position, new Quaternion(0f, 0f, fireAngle, 0f));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = other.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = null;
        }
    }
}
