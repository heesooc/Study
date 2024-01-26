using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class Test19 : MonoBehaviour
{
    public int N = 5;
    

    void Start()
    {
        string s = "";
        //이 문제를 못풀었다면 string이 어색한 것

        for (int i = 1; i < N + 1; i++) // 1 // 2
        {

            for (int j = N; j < N+1; j++) // 1 // 1 2
            {
                

                s += "*"; //s = s + * // * // * ** 
            }

            Debug.Log(s);


        }
       
    }
    

}
*/


public class Test19 : MonoBehaviour
{
    public int N = 5;

    void Start()
    {
        for (int i = 1; i <= N; i++)
        {
            string star = "";

            for (int j = 0; j < i; j++)
            {
                star += "*";
            }

            Debug.Log(star);
        }
    }
}

