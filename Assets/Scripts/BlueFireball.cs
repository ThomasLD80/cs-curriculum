using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFireball : MonoBehaviour
{
    private GameObject player;
    public float moveSpeed = 5f;

    public float angleBetween;
    Rigidbody fireball_Rigidbody;

    TurretFire turretScript;
    // Start is called before the first frame update
    void Start()
    {
        
        Vector3 targetDir = turretScript.target.position - transform.position;
        angleBetween = Vector3.Angle(transform.forward, targetDir);
        fireball_Rigidbody = GetComponent<Rigidbody>();
        
        transform.Rotate(new Vector3(0f, 0f, angleBetween) * Time.deltaTime * moveSpeed, Space.World);

        //Vector3 direction = turretScript.target.position - transform.position;
        //float angle = Mathf.Atan2(direction.y, direction.x);
        //Vector3 newLocation = transform.position + direction.normalized * Time.deltaTime;
        //transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg);
    }

    // Update is called once per frame
    void Update()
    {
        //fireball_Rigidbody.AddForce(new Vector3(moveSpeed, 0f, 0f) * moveSpeed);
        
        //fireball_Rigidbody.transform.position = new Vector3(
        //    transform.position.x + (moveSpeed * Time.deltaTime),
        //    transform.position.y,
        //    transform.position.z
        //    );
        
        //transform.Translate(new Vector3((moveSpeed * Time.deltaTime),
        //    (moveSpeed * Time.deltaTime) - 2f,
        //    0f
        //    ));
        
        //fireball_Rigidbody.velocity = transform.forward * moveSpeed * Time.deltaTime;
    }
}
