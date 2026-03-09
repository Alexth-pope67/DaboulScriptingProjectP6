using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if (down)
        {
            Debug.Log("Get Button Down is: " + down);
        }
        else if (held)
        {
            Debug.Log("Get Button held is: " + held);
        }
        else if (up)
        {
            Debug.Log("Get Button Up is: " + up);
        }
        else
        {
            Debug.Log("Get Button Down is: " + down);
            Debug.Log("Get Button held is: " + held);
            Debug.Log("Get Button Up is: " + up);
        }
    }
}
