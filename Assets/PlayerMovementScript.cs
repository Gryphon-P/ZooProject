using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    // Defines player move speed
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Forward Movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.position +=  Vector3.up * moveSpeed * Time.deltaTime;
        }

        // Down Movement
        if (Input.GetKey(KeyCode.S)) 
        { 
            transform.position -= Vector3.up * moveSpeed * Time.deltaTime;
        }

        // Right movement
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }

        // Left Movement
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }


    }
}
