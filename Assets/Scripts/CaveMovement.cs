using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveMovement : MonoBehaviour
{
    float WalkingSpeed;
    float xDirection;
    float xVector;
    // Start is called before the first frame update
    void Start()
    {
        WalkingSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * WalkingSpeed * Time.deltaTime;
    }
}
