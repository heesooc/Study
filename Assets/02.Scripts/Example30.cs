using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example30 : MonoBehaviour
{
    void Start()
    {
        /*
         - 1차원 배열과 2차원 배열의 차이
        * 1차원 배열 
        [0] [1] [2] [3] [4] 
        
        * 2차원 배열
        [0,0] [0,1] [0,2] [0,3] [0(←2차원),4(←1차원)]
        [1,0] [1,1] [1,2] [1,3] [1,4]
        [2,0] [2,1] [2,2] [2,3] [2,4]
         */

        // 2차원 배열: 세로와 가로 형태로 된 배열
        // 콤마(,)로 인덱스를 구분한다.
        // 자료형[,] 배열명 = new 자료형[세로 크기,가로 크기];

        string[,] jari = new string[3, 5];

        jari[0, 0] = string.Empty; jari[0, 1] = string.Empty; jari[0, 2] = "민예진"; jari[0, 3] = "이윤석"; jari[0, 4] = "정성훈";
        jari[1, 0] = "김성준"; jari[1, 1] = "이태환"; jari[1, 2] = "고승연"; jari[1, 3] = "공지수"; jari[1, 4] = "조희수";
        jari[2, 0] = "김경희"; jari[2, 1] = "정수빈"; jari[2, 2] = "전민성"; jari[2, 3] = "이성민"; jari[2, 4] = "김예은";
   
        for (int y = 0; y<3; y++)
        {
            for (int x = 0; x<5; x++)
            {
                Debug.Log(jari[y, x]);
            }
            
        }

        Debug.Log(jari.Length); // 15 -> 배열의 길이(크기) also.있음 세로(3) * 가로(5)
        Debug.Log(jari.GetLength(0)); // 3 // 세로의 길이 // 0번째 차원의 길이를 갖고 온다
        Debug.Log(jari.GetLength(1)); // 5 // 가로의 길이 // 1번째 차원의 길이를 갖고 온다



    }

   
}

