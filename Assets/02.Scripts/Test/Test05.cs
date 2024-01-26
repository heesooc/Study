using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test05 : MonoBehaviour
{
    public int Height = 180;
    public int Weight = 64;
    void Start()
    {
        double HeightM = Height * 0.01;
        double BMI = Weight / (HeightM * HeightM);
        Debug.Log(BMI);

    }

    
}
