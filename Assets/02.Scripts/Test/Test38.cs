using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test38 : MonoBehaviour
{
    public string S = "baekjoon";
    void Start()
    {
        /*// a b c d e f g h i j k l m n o p q r s t u v w x y z (26개 ) 에 대해서,
        // 처음 등장하는 위치를, or 포함되어 있지 않은 경우 -1 출력


        // 각 알파벳이 처음 등장하는 위치를 저장할 배열을 선언합니다.
        int[] positions = new int[26];

        // 배열을 -1로 '초기화'합니다.
        for (int i = 0; i < positions.Length; i++)
        {
            positions[i] = -1; //없으면 -1임. 
        }


        // 문자열을 순회하면서 각 알파벳의 위치를 기록합니다.
        for (int i = 0; i < S.Length; i++)
        {
            char currentChar = S[i]; //첫 currentChar = 'b'
            int index = currentChar - 'a'; //ASCII 코드에서 문자 'a'의 값은 97 //이를 이용하여 문자열에서 특정 알파벳의 위치를 찾을 때 유용하게 사용
            //예를 들어, 'c'의 경우 currentChar - 'a'는 2가 됩니다. 이 값은 배열에서 'c'에 해당하는 인덱스를 나타내기 때문에 배열에서 'c'의 등장 위치를 저장하는 데 사용됩니다.



            // 처음 등장하는 경우에만 위치를 기록합니다.
            if (positions[index] == -1)
            {
                positions[index] = i; //i는 위치: 0번째 ~25번째.
            }
        }

        for (int i = 0; i < positions.Length; i++)
        {
            char currentChar = (char)('a' + i);
            int position = positions[i];

            Debug.Log($"{currentChar}: {position}");// ex) a: 1 / b: 0 / c: -1 /.../ z: -1
        }*/



        
        for (char i = 'a'; i<='z'; i++)
        {
            int result = S.IndexOf(i);
            Debug.Log(result);
        }

    }


}
