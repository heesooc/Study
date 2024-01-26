using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test26 : MonoBehaviour
{
    public int[] A;

    void Start()
    {
        int[] A = new int[] {20, 10, 35, 30, 7};
        //float sum = 0;
        int sum = 0;
        float average = 0;

        for (int i = 0; i < A.Length; i++)
        {
            sum += A[i]; // sum = 102
            
        }

        average = (float)sum / A.Length; // 102 / 5 = 20.4

        Debug.Log($"{average:F1}"); 
    }

    
}
