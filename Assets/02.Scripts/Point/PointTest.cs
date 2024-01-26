using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTest : MonoBehaviour
{
    void Start()
    {
        // 구조체는 new 키워드를 사용하지 않아도 변수를 선언할 수 있다.
        // 대신 직접 모든 속성(변수)를 초기화 해줘야 사용할 수 있다. 
        // Point point1;
        // point1.X = 3;
        // point1.Y = 7;
        Point point1 = new Point(3, 7);
        Debug.Log($"x: {point1.X}, y: {point1.Y}");

        Point point2 = new Point(4, 5);
        Debug.Log($"x: {point2.X}, y: {point2.Y}");

        point2 = point1; // p2 = (3, 7) 
        point2.X = 16;  // p2 = (16, 7), p1도 같은 상자 참조. -> struct구조체로 변경 후, p1 값은 (3,7) 그대로.
        Debug.Log("---------- 변경 후 -----------");

        Debug.Log($"x: {point1.X}, y: {point1.Y}"); // p1 = (16, 7) // -> p1 = (3, 7)
        Debug.Log($"x: {point2.X}, y: {point2.Y}"); // p2 = (16, 7) // -> p2 = (16, 7)

    }
}
