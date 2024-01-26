using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test12 : MonoBehaviour
{
    public int A = 14;
    public int B = 30;
    public int C = 20;

    // 현재 시각: A시 B분 // 23시 59분 // 17시 40분 
    // 필요한 시간: C분단위 //1분 // 80분
    // 최종 시간: A'시 B'분 // 0시 0분 (23시 60분 -> 24시 0분-> 0시 0분) // 17시 120분(60*2) = 19시

    void Start()
    {


        if (A < 23) // 14 // 17
        {
            B = B + C; // 50  // 120 
            if (B % 60 == 0)
            {
                
                A = A + ( B / 60 );
                B = 0;

            }
            else if( B >= 60 )
            {
                B = B - 60;
                A = A + 1;
            }

            Debug.Log($"{A} {B}");

        }

        else // A = 23
        {
            B = B + C;
            if (B >= 60)
            {
                B = B - 60;
                A = 0;
            }

            Debug.Log($"{A} {B}");
        }
    }

    /*
     public class Test12 : MonoBehaviour
{
    public int Hour = 14;
    public int Min  = 30;

    public int AddMin = 20;

    void Start()
    {
        int newHour = Hour;
        int newMin  = Min + AddMin;

        // 만약 분이 60분보다 같거나 크면
        if(newMin >= 60)
        {
            newHour += (newMin / 60);  // 시간은 더해주고
            newMin = (newMin % 60);    // 분은 나머지.
        }

        if(newHour >= 24)
        {
            newHour -= 24;
        }

        Debug.Log($"{newHour} {newMin}");
    }
}

     */
}
