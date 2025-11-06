using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{

    //create an integer variable
    int MyInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        //run the variable through my function
        MyInt = MultiplyByTwo(MyInt);

        //display the result in the console 
        Debug.Log(MyInt);

    }

    // Update is called once per frame
    void Update()
    {

    }

    //create my function
    int MultiplyByTwo(int number)
    {
        //create A results variable
        int result;
        result = number * 2;

        //return the result
        return result;


    }

}
