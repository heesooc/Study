using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test20 : MonoBehaviour
{
    public int N = 6;

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

    //어렵 패스
}
