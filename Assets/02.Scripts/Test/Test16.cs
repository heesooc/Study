using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test16 : MonoBehaviour
{
    public int N;
    void Start()
    {
        int Factorial = 1;

        for (int i = 1; i < N + 1; i++)
        {
            Factorial = Factorial * i;


        }

        Debug.Log(Factorial);
    }

    
}
