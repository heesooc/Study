using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test13 : MonoBehaviour

{
    public int Dice1 = 3;
    public int Dice2 = 3;
    public int Dice3 = 6;

    void Start()
    {
        int price = 0;

        if (Dice1 == Dice2 && Dice2 == Dice3)
        {
            price = 10000 + (Dice1 * 1000);
        }

        else if (Dice1 == Dice2 || Dice2 == Dice3 || Dice3 == Dice1) 
        {
            if (Dice1 == Dice2)
            {
                price = 1000 + (Dice1 * 100);
            }

            else if (Dice2 == Dice3)
            {
                price = 1000 + (Dice2 * 100);
            }

            else
            {
                price = 1000 + (Dice3 * 100);
            }
        }

        else
        {
            if (Dice1 > Dice2 && Dice1 > Dice3)
            {
                price = Dice1 * 100;
            }
            
            else if (Dice2 > Dice1 && Dice2 > Dice3)
            {
                price = Dice2 * 100;
            }

            else
            {
                price = Dice3 * 100;
            }
        }

        Debug.Log(price);

    }

   
}
