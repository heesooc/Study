using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test36 : MonoBehaviour
{
    public string S = "54321";

    void Start()
    {
        int sum = 0;

 
        foreach (char digitalChar in S)
        {
            // digitalChar.ToString() 
            // : char -> 문자열로 변환한 후 -> 정수로 변환
            int digit  = int.Parse(digitalChar.ToString()); 
            
            sum += digit;
        }
        
        Debug.Log(sum);
        
    }
}

    
