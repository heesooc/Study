using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    public int A;
    public int B;
    public int C;


    void Start()
    {
        Debug.Log((A + B) % C);
        Debug.Log(((A % C) + (B % C)) % C);
        Debug.Log((A*B) % C);
        Debug.Log(((A % C) * (B % C)) % C);
    }

    
}
