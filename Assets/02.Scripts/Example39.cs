using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example39 : MonoBehaviour
{
    // 값에 의한 전달 (Call By Value)
    // - 변수나 상수로부터 값을 복사해서 전달.
    
    // 참조에 의한 전달 (Call By Reference)
    // - 값을 복사하는 것이 아닌 원본 변수를 참조(비추어 보다.)
    // - 원본 변수를 참조 중이므로 값을 변경하면 원본 변수의 값도 변경된다.
    // - 사용 방법: 매개 변수 앞에 ref 키워드 사용.
    void Swap(ref int num1, ref int num2) //Swap =  교환 // ref:'참조'하다 - 값 뿐만 아니라 상자 참조(c언어로는 포인터)
    {
        int tempNum = num1;
        num1 = num2;
        num2 = tempNum;

    }

    // ref 키워드는 함수 내부에서 원본 변수의 값을 수정하지 않아도 되지만
    // out 키워드는 함수 내부에서 무조건 원본 변수의 값을 수정해야 한다.
    // ref와 비슷하지만 개발자의 실수를 줄여준다.

    /***Swap, Change 상황에서 out 굳이 쓰지 않음. 
    void Change(out int num1, out int num2)
    {
        num1 = 1;
        num2 = 2;
        int tempNum = num1;
        num1 = num2;
        num2 = tempNum;

    }
    /***/

    void Test (out int num)
    {
       num = 2;
       // out이 실수-를 줄여줌. ref 잘 안씀.
    }
    

    void Start()
    {
        int num1 = 3;
        int num2 = 9;

        Debug.Log($"바뀌기 전: num1={num1}, num2={num2}");

        Swap(ref num1, ref num2); // 그냥 num1, num2 부르면, 지역 변수 3, 9 그대로 안에서 불러옴

        Debug.Log($"바뀐 후: num1={num1}, num2={num2}");

        Test(out num1);
        //Debug.Log(Test(out num1));(x) //void에서 object 형태로 반환 X.
        //Debug.Log($"{num1}");
        Debug.Log(num1);

        /*  Change(out num1, out num2);
          Debug.Log($"{num1}, {num2}"); */

        /*
        Swap(ref num1, ref num2);
        Debug.Log($"바뀐 후: num1={num1}, num2={num2}");
        */
    }

    
}
