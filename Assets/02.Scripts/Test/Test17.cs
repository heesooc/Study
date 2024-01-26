using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test17 : MonoBehaviour
{
    public int N = 2;
    void Start()
    {
        for (int i = 1; i < 10; i++)
        {

            Debug.Log($"{N} * {i} = {N*i}");

        }

        
    }

    
}
