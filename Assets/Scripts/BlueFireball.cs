using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFireball : MonoBehaviour
{
    private GameObject player;
    public float moveSpeed;

    public float angleBetween;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir = target.position - transform.position;
        angleBetween = Vector3.Angle(transform.forward, targetDir);
        transform.Rotate(0f, 0f, angleBetween);
        transform.forward = new Vector3(moveSpeed,0f,0f);
    }
}
