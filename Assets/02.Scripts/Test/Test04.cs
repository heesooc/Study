using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    public int A = 472;
    public int B = 385;

    void Start()
    {
        // A * B 의 1의 자리
        int num3 = A * (B % 10);
        //num3 = 472 * 5

        // A * B 의 10의 자리
        int num4 = A * (B / 10 % 10);

        // A * B 의 100의 자리
        int num5 = A * (B/100);

        // 총 값
        int num6 = A * B;

        Debug.Log(num3);
        Debug.Log(num4);
        Debug.Log(num5);
        Debug.Log(num6);
        
    }

    
}
