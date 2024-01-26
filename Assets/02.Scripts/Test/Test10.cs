using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test10 : MonoBehaviour
{
    public int X = 12;
    public int Y = 5;
    void Start()
    {
        if(X > 0)
        {
            if (Y > 0)
            {
                Debug.Log(1);
            }
            else
            {
                Debug.Log(4);
            }
        }
        else
        {
            if (Y > 0)
            {
                Debug.Log(2);
            }
            else
            {
                Debug.Log(3);
            }
        }
    }

   
}
