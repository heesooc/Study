using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    public int A;
    public int B;
    void Start()
    {
        int A=90;
        int B=10;
        int C=0;

        C = A;
        A = B;
        B = C;

        Debug.Log(A);
        Debug.Log(B);
    }

   
}
