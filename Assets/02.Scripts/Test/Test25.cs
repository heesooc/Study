using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Test25 : MonoBehaviour
{
    public int[] A;
    void Start()
    {
        int[] A = new int[] {20, 10, 35, 30, 7};

        int max = A[0];
        int min = A[0];

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
            } 
            
            if (A[i] < min)
            {
                min = A[i];
            }
        }

        Debug.Log(min); Debug.Log(max); 
    }

    
}
