using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test15 : MonoBehaviour
{
    public int n; // n = 3
    void Start()
    {
        int sum = 0;

        for (int i = 1; i < n + 1; i++)
        {
            if (i % 3 != 0) // 1, 2
            {
                sum += i; 
            }
        }

        Debug.Log(sum);
    }

    
}
