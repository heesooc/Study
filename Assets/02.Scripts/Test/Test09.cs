using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test09 : MonoBehaviour
{
    public int Year = 2000;
    void Start()
    {

        if(Year % 4 == 0)
        {
            if (Year % 100 != 0 || Year % 400 == 0) 
            {
                Debug.Log(1);
            }
            
        }
        else
        {
            Debug.Log(0);
        }
    }

   
}
