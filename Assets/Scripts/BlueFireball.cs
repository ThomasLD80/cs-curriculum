using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFireball : MonoBehaviour
{
    private GameObject player;
    public float moveSpeed;

    public float angleBetween;
    Rigidbody fireball_Rigidbody;

    TurretFire turretScript;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
        Vector3 targetDir = turretScript.target.position - transform.position;
        angleBetween = Vector3.Angle(transform.forward, targetDir);
        fireball_Rigidbody = GetComponent<Rigidbody>();
        
        transform.Rotate(new Vector3(0f, 0f, angleBetween) * Time.deltaTime * moveSpeed, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        //fireball_Rigidbody.AddForce(new Vector3(moveSpeed, 0f, 0f) * moveSpeed);
        
        fireball_Rigidbody.transform.position = new Vector3(
            transform.position.x + (moveSpeed * Time.deltaTime),
            transform.position.y,
            transform.position.z
            );
    }
}
