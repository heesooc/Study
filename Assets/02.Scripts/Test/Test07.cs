using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test07 : MonoBehaviour
{
    public int A = 3;
    public int B = 1;
    public int C = 2;

    // 오름차순 

    void Start()
    {
        if (A < B)
        {
            if (B < C)
            {
                Debug.Log($"{A} {B} {C}");
            }
            else if (C < A)
            {
                Debug.Log($"{C} {A} {B}");
            }
            else
            {
                Debug.Log($"{A} {C} {B}");
            }

        }
        else // B < A
        {
            if (C < B)
            {
                Debug.Log($"{C} {B} {A}");
            }
            else if (A < C)
            {
                Debug.Log($"{B} {A} {C}");
            }
            else
            {
                Debug.Log($"{B} {C} {A}");
            }

        }
    }
}
