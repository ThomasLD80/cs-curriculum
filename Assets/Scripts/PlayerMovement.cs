using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private float walkingSpeed;
    private float xDirection;
    private float xVector;
    private float yDirection;
    private float yVector;
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

        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Overworld")
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
