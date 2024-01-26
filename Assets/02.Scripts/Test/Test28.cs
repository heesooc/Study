using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test28 : MonoBehaviour
{
    
    public int[] Student; //A[27] _28명까지 있음
    // 1- 30번 중 포함 안 된 번호 2개 출력
    

    void Start()
    {

        int[] Student = new int[28]; 
       

        for (int i = 0; i < 28; i++) //28명 제출 여부 배열
        {
            int n = i;
          //  Debug.Log(min);
            Student[n] = 1;
            
        }

        for (int i = 1;i <= 30; i++)
        {
            if (Student[i] != 1) 
            {
             //   Debug.Log(max);
            }
        }

        // 입력되지 않은 것 중 가장 작은 번호: min 출력
        // 큰 번호: max 출력


        /*학생: 1- 6*/
        // 과제 제출부 : [4번][1번][6번][5번]
                        // [*] [ ] [ ] [*] [*] [*] 
                // 인덱스 [0] [1] [2] [3] [4] [5] 
        // bool 이용 FALSE FALSE

        // 1+1 // 2+1
        // 2   // 3
    }

}
