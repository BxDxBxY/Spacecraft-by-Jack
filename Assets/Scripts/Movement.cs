using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        ProcessInput();
    }
    void ProcessInput()
    {
            if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Yes up");
        }
    }
}
