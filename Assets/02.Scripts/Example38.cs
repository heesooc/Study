using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example38 : MonoBehaviour
{
    // 가변 길이 매개 변수
    // -> 매개 변수 개수가 유연하게 변한다.
    int Add(params int[] nums)
    {
        
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        return sum;
    } 

    void Start()
    {
        
        Debug.Log(Add(1));
        Debug.Log(Add(1, 2));
        Debug.Log(Add(1, 5, 2));
        Debug.Log(Add(1, 232, 55, 2));
        // Debug.Log(C); //'C' 이름이 현재 컨텍스트(context:문맥,지역상자)에 없습니다.
    }

    
}
