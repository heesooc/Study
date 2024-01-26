using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test06 : MonoBehaviour
{
    public int A = 1;
    public int B = 2;

    void Start()
    {
        if (A > B)
        {
            Debug.Log(">");
        }
        else
        {
            if(A < B)
            {
                Debug.Log("<");
            }
            else
            {
                Debug.Log("==");
            }
        }

    }

    
}
