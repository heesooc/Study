using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test30 : MonoBehaviour
{
    public int[] A;
    public int B = 42;
    void Start()
    {
        /*
        // int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // A % B = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10} % 42 = 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 
        
        // 나머지를 구하고 중복을 제외한 서로 다른 값 개수 구하기
        int[] remainders = new int[42]; // 이후 42번 돌아가야함 for문에서
       

        foreach (int number in A)
        {
            int remainder = number % B; // remainder = 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 

            remainders[remainder] = 1; // 나머지 모음 (배열) // remainders[1] = 1, remainders[2] = 1, remainders[3] = 1 ... remainders[10] = 1;

        }

        // 서로 다른 값의 개수 세기
        int count = 0;
        
        for (int i = 0; i < B; i++) 
        {
            if (remainders[i] == 1)
            {
                   count++;
            }
        }

        // 결과 출력
        Debug.Log(count);
        */

        int[] A = new int[] { 42, 84, 252, 420, 840, 126, 42, 84, 420, 126 };

        // 나머지 값을 체크하기 위한 배열
        bool[] checks = new bool[42];

        // 1. 배열 A의 모든 값을 확인하고 싶다.
        for (int i = 0; i < A.Length; i++)
        {
            checks[A[i]%42] = true; // A[i]%42= 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 // checks[0] = true

        }
        // 서로 다른 나머지가 몇 개 있는지 출력한다.
        int count = 0;
        // 3. checks 배열에서 true 개수를 구한다.
        foreach(bool check in checks)
        {
            if (check == true)
            {
                count++;
            }
            
        }
    
        Debug.Log(count);
    
    
    }




}
