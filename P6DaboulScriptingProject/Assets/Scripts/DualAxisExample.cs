using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxisExample : MonoBehaviour
{
    public float hRange = 10f; // Added default values for convenience
    public float vRange = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the WASD keys or Arrow keys
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Calculate the new position based on input and range
        float xPos = h * hRange;
        float vPos = v * vRange;

        // Apply the position to the object (moving on the X and Z plane)
        transform.position = new Vector3(xPos, 0, vPos);

        // Optional: If you still want to see the values without UI, use the Console
        // Debug.Log($"Horizontal: {h:F2}, Vertical: {v:F2}");
    }
}
