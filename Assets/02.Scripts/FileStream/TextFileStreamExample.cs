using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

// 파일스트림**
// 파일을 다룰 때 데이터가 움직이는 것을 흐름(stream)으로 비유한 것
// 파일을 다루기 위해서는 System.io(Input/Output) 네임스페이스에 있는 FileStream 클래스 사용

public class TextFileStreamExample : MonoBehaviour
{
    void Start()
    {
        // <파일 열기>

        // 매개변수
        // 1. 어떤 파일?        (파일의 경로) 
        // 2. 어떻게 다룰거냐?  (파일의 모드)
        FileStream fileStream = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);// 타입 변수명 = 생성자 함수
        // FileMode.Create: 파일이 없다면 새로 생성해주고, 있으면 덮어씨운다.    //바탕화면 창에 빈 메모장 생김! 아뿔싸 덮어씌우면 다사라짐
   
        // <파일 쓰기>
        // 텍스트 파일을 쓸 때는 "StreamWriter" 클래스 사용
        StreamWriter streamWriter = new StreamWriter(fileStream);
        streamWriter.WriteLine("Hello.");
        streamWriter.WriteLine("제 이름은 조희수입니다.");
        streamWriter.WriteLine("만나서 반가워요.");
        streamWriter.Close(); // 파일을 다 쓰면 꼭! 닫아줘야함!

        // <파일 읽기>
        fileStream = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open); // 다시 열기
        StreamReader streamReader = new StreamReader(fileStream);
        //반복문 이용해 구현
        while (true) // 순서 명확하지 않고 유동적일 때 while 반복문 사용
        {
            string line = streamReader.ReadLine();
            if (line == null)
            {
                break;
            }
            Debug.Log(line); //ReadLine: 한줄만 읽는다
        }
        
        streamReader.Close();

    }

}
