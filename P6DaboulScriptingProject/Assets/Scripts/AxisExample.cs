using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisExample : MonoBehaviour
{
    public float range = 5f; // Set a default value for movement

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the input value (between -1 and 1)
        float h = Input.GetAxis("Horizontal");

        // Calculate the new X position based on input and range
        float xPos = h * range;

        // Apply the position to the object (keeping Y at 2 and Z at 0)
        transform.position = new Vector3(xPos, 2f, 0);

        // Optional: If you still want to see the value without using UI, 
        // you can print it to the Console window instead:
        // Debug.Log("Value Returned: " + h.ToString("F2"));
    }
}
