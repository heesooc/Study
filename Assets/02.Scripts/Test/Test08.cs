using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Test08 : MonoBehaviour
{
    public int Score = 100;

    void Start()
    {
        /**
        if (Score >= 90 && Score <= 100)
        {
            Debug.Log("A");
        }
        else if (Score >= 80 && Score < 90)
        {
            Debug.Log("B");
        }
        else if (Score >= 70 && Score < 80)
        {
            Debug.Log("C");
        }
        else if (Score >= 60 && Score < 70)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
    }

   **/

        switch (Score / 10)
        {
            case 10:
            case 9:
                {

                    Debug.Log("A");
                    break;
                }

            case 8:
                {
                    Debug.Log("B");
                    break;
                }

            case 7:
                {
                    Debug.Log("C");
                    break;
                }

            case 6:
                {
                    Debug.Log("D");
                    break;
                }

            default:
                {
                    Debug.Log("F");
                    break;
                }
        }


        /**
        switch (Score)
        {
           
            case >= 90:
                {

                    Debug.Log("A");
                    break;
                }
        }
        **/
    }
}
