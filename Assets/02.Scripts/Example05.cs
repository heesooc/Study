using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example05 : MonoBehaviour
{
    int age = 20;


    
    void Start()
    {
        Debug.Log(age);


        age = 17;

        Debug.Log(age);

        age = 19;
        Debug.Log(age);

    }


    void Update()
    {
        
    }
}
