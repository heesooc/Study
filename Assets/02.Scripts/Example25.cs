using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example25 : MonoBehaviour
{
    // (클래스의)멤버 변수 // 문제 풀 때 이용
    public int[] N;
    

    
    void Start()
    {
        // Length 속성: 배열의 길이
        Debug.Log(N.Length);

        int count = N.Length;

        for (int i = 0; i < count; i++)
        {
            Debug.Log(N[i]);
        }

        /*
        Debug.Log(N[0]);
        Debug.Log(N[1]);
        Debug.Log(N[2]);
        */
    }
}
