using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test33 : MonoBehaviour
{
    public string Word = "The Curious Case of Benjamin Button";

    void Start()
    {
        
        int count = 0;
        
        for (int i = 0; i < Word.Length; i++)
        {
            char spell = Word[i];
            if (spell == ' ')
            {
                count++;
                
            }
            
        }
        Debug.Log(count + 1);

    }

    
}
