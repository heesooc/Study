using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test29 : MonoBehaviour
{
    public int[] A;
    public int[] B;
    public int[] C;

    void Start()
    {
        /*
        int[] A = new int[] {3, 29, 38, 12, 57, 74, 40, 85, 61 }; <-- 이 경우에만 가능한 코드, 즉 잘못짬 ^-^ 
        int[] B = new int[A.Length];

        // N = A.Length - 1
        // A[0] A[1] A[2] A[3] ... A[8] (A[N])      // A[N-N], A[N-(N+1)] .. A[N] 
        // -> A[8] A[7] A[6] ... A[0]               // -> A[N], A[N-1], A[N-2] .. A[N-N]
        // 출력을 반대로 하는게 아닌
        // 실제 배열 안 원소의 값이 바뀌어야함 


        for (int i = 0; i <= A.Length / 2; i++)  
        {
            B[i] = A[i];                // B[0] = A[0] = 3 // B[1] = A[1] = 29 // B[3] = A[3] = 12
            A[i] = A[A.Length - (i+1)]; //A[0] = A[8] = A[9-1] // A[1] = A[7] = A[9-2] 
                                        //A[5] = A[3] = A[9-6] // 그냥하기엔 이미 A[0]~A[3] 값이 바뀜 //그럼 다 저장(살려야함)

            Debug.Log(A[i]);
        }

        for (int i = (A.Length / 2) + 1; i < A.Length; i++)  // i = 5, 6, 7, 8
        {
            A[i] = B[A.Length - (i + 1)];  //A[5] = A[3] = B[3] // A[6] = A[2] = B[2]


            Debug.Log(A[i]);
        }
        */

        /* for문 나눌 필요 없이 옮긴 B배열에서 한번에 A배열로 바꿔주면 됨. */

        int[] A = new int[] { 3, 29, 38, 12, 57, 74, 40, 85, 61 };
        int[] B = new int[A.Length];
        int[] C = new int[A.Length];

        // 1. 배열 A의 각 요소의 값을 B로 복사한다.
        for (int i = 0; i < A.Length; i++) // for문 나눠서 쓰니까 되버림. !!
        {
            B[i] = A[i]; // int[] B = new int[] {10, 20, 30, 40, 50, 60} // B[0] = A[0] = 10
            
        }

        // 2. 배열 B의 각 요소의 값을 거꾸로 A로 복사한다. 
        for (int j = 0; j < A.Length; j++)
        {
            C[j] = B[A.Length - (j+1)]; // C[0] = B[5]= B[6-1] // C[0] = B[5] = 60
            Debug.Log(C[j]); // 0 0 0 30 20 10 why??

        }
        

    }


}
