using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test18 : MonoBehaviour
{
    public int N = 2;

    void Start()
    {
        for (int N = 2; N < 10; N++)
        {
            for (int i = 1; i < 10; i++)
            {
                Debug.Log($"{N} * {i} = {N * i}");
            }


        }
    }

}
