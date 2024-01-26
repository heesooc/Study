using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test23 : MonoBehaviour
{
    public int[] N; // [1 4 1 2 4 2 4 2 3 4 4] // N(0)=1, N(1)=4, N(2)=1, N(3)=2, N(4)=4, N(5)=2, N(6)=4, N(7)=2, N(8)=3, N(9)=4, N(10)=4 
    public int v; // 2 

    void Start()
    {
        int[] N = new int[] { 1, 4, 1, 2, 4, 2, 4, 2, 3, 4, 4 };


         int count = N.Length; // 총 개수
        int sum = 0;

        for (int i = 0; i < count; i++)
        {
            if (N[i] == v) // 1!=2 4!=2 ... 2=2
            {
                
                sum += 1;
                

            }
           
            
        }
        Debug.Log(sum); // v가 몇 개인지 // 3

    }

    
}
