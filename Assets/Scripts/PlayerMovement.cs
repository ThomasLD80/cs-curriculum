using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float walkingSpeed;
    private float xDirection;
    private float xVector;
    private float yDirection;
    private float yVector;
    
    public bool Overworld;
    // Start is called before the first frame update
    void Start()
    {
        walkingSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * walkingSpeed * Time.deltaTime;
        yDirection = Input.GetAxis("Vertical");

        if (Overworld)
        {
            yVector = yDirection * walkingSpeed * Time.deltaTime;
        }
        else
        {
            yVector = 0f;
        }

        transform.position = transform.position + new Vector3(xVector, yVector, 0f);
    }
}
