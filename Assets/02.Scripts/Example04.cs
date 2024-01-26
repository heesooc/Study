using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 멤버 변수(프로퍼티)
    // 클래스 내부, 함수 외부에서 선언되는 변수
    // 해당 클래스 내에서 접근 및 사용 가능
    // float height = 185.2f;
    // string name = "조희수";

    void Start()
    {
        //Debug.Log(name);
        // 주제, 변수의 스코프(범위)

        // 지역 변수: 함수 내부에서 선언되는 변수
        // 변수가 선언된 위치로부터 아래에서만 사용이 가능
        // 선언 함수 내부의 코드 블록({ ... }) 에서만 사용 가능

        int age = 20;
        
        Debug.Log(age);

        // Debug.Log(height);
        // Debug.Log(name);

        float height = 169.2f;

        Debug.Log(height);
    }

    void Update()
    {
        
        //Debug.Log(age);
    }
}
