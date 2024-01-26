using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test35 : MonoBehaviour
{


    void Start()
    {
        //string[] A = { "ACDKJFOWIEGHE", "O", "AB" };
        //string[] A = { "ABC" };
        string[] A = { "K", "KK", "KKO" };

        foreach (string str in A)
        {
            if (str.Length > 0)
            {
                char firstChar = str[0];
                char lastChar = str[str.Length - 1];

                Debug.Log($"{ firstChar}{ lastChar}");
            }
        }

        


    }   
}
