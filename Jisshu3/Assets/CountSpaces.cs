using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountSpaces : MonoBehaviour
{
    int number;
    void Start()
    {
        number = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //???
            print(number);
        }
    }
}
