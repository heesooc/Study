using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test37 : MonoBehaviour
{
    public string S = "Hello C#";
    void Start()
    {
        string result = "";
        for (int i = S.Length-1; i >= 0; i--)
        {
            result += S[i];
            
        }
        Debug.Log(result);
    }

    
}
