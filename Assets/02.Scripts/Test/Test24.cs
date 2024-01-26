using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test24 : MonoBehaviour
{
    public int[] A;
    public int X; // 5
    void Start()
    {
        int[] A = new int[] {1, 10, 4, 9, 2, 3, 8, 5, 7, 6};

        int count = A.Length; // 총 개수 // 10
        

        for (int i = 0; i < count; i++)
        {
            if(A[i] < X)
            {
                Debug.Log(A[i]); // A에서 X보다 작은 수 모두 출력 // 1 4 2 3
            }
            

        }

        
    }

    
}
