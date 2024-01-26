using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test31 : MonoBehaviour
{
    public string Word = "shiftpsh";
    public int number = 6;

    void Start()
    {
        Debug.Log(Word[0]);

        char result = char.ToUpper(Word[number - 1]);
        Debug.Log(result);


    }


}
