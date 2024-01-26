using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example31 : MonoBehaviour
{

    void Start()
    {
        // 배열 초기화
        int[] arr = new int[] { 1, 2, 3 };

        // 2차원 배열 초기화 
        int[,] arr2 = new int[,]
        {
            { 31, 28, 45 },
            { 10, 56, 68 }
        };

        Debug.Log(arr[0]);
        Debug.Log(arr2[0,0]);

    }

}
