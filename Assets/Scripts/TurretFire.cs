using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour
{
    public GameObject fireball;
    public Transform target;

    private float targetPositionX;
    private float targetPositionY;

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
            targetPositionX = target.position.x;
            targetPositionY = target.position.y;
            fireAngle = targetPositionY / targetPositionX;
            
            //Instantiate(fireball, transform.position, new Quaternion(0f, 0f, fireAngle));
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
