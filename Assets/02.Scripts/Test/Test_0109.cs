using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TestTools;

public class Test_0109 : MonoBehaviour
{
    // Q1. 정수 2개를 매개변수로 넘겨받아 두 수 중 더 큰 수를 반환하는 함수를 만들고 테스트

    // Q2. 정수 3개를 매개변수로 넘겨받아 평균을 구해 반환하는 함수를 만들고 테스트 (평균은 소수점이 있음)

    // Q3. 정수값을 입력받아 0부터 해당 정수 값까지 출력해 주는 함수를 만들고 테스트 (반환안함)



    int Max(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        return num2;
    }

    float Average(int num1, int num2, int num3) // 반환할 때도 소수점(실수형)
    {
        int sum = num1 + num2 + num3;
        float average = (float)sum / 3;
        return average;
    }

    void Integer(int num)
    {
        for (int i = 0; i <= num; i++) 
        {
            Debug.Log(i);
        }
    }


    void Start()
    {
        // 호출: 함수이름(매개변수);
        Debug.Log(4);
        Debug.Log(Mathf.Max(6, 4));

        int result = Max(17, 9);
        Debug.Log(result);


        float result1 = Average(17, 9, 8);
        Debug.Log(result1);


        Integer(17); // 반환 안 했기 때문에 함수 호출.
    }

    
}
