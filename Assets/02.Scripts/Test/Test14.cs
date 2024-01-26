using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test14 : MonoBehaviour
{
    public int n = 3;

    void Start()
    {
        
        int Sum = 0;

        for (int i = 1; i < n+1 ; i++)
        {
            Sum = Sum + i; 

        }

        Debug.Log(Sum);
    }

    
}
