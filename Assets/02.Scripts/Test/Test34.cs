using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test34 : MonoBehaviour
{
    // 아스키 코드
    // char 자료형 변수 C에 알파벳 소문자, 대문자, 숫자 0-9중 하나가 주어질 때, 주어진 글자의 아스키 코드값을 출력
    public char[] C = new char[] { 'A', 'C', '0', '9', 'a', 'z' };
    

    void Start()
    {
        char c = C[5];
        int i =(int)c;
        Debug.Log(i);
    }

    
}
