using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        KeyboardInputs();
    }

    void KeyboardInputs()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter Key Pressed");

        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("#1 Pressed (not keypad)");

        }

    }
}
