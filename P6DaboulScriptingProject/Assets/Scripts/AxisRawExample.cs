using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisRawExample : MonoBehaviour
{
    public float range = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get input (-1, 0, or 1)
        float h = Input.GetAxisRaw("Horizontal");

        // Calculate position based on range
        float xPos = h * range;

        // Apply position to the object
        transform.position = new Vector3(xPos, 2f, 0);

        // Optional: Print to the Console instead of UI
        // Debug.Log("Value Returned: " + h.ToString("F2"));
    }
}
