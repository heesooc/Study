using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test11 : MonoBehaviour
{
    public int H = 10;
    public int M = 10;
    // H시 M분

    void Start()
    {
       
        if (M < 45)
        {
            if(H  >= 1)
            {
                H = H - 1;
                M = M + 60;  // 9시 70분
                M = M - 45;

                Debug.Log($"{H} {M}");
            }
            
            else
            {
                H = 23;
                M = M + 60;  
                M = M - 45;

                Debug.Log($"{H} {M}");
            }
            

        }

    }

    
}
