using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BinaryFileStreamExample : MonoBehaviour //2진수
{
    void Start()
    {
        // <파일 열기>
        // 매개변수
        // 1. 어떤 파일?        (파일의 경로) 
        // 2. 어떻게 다룰거냐?  (파일의 모드)
        FileStream fileStream = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);
        // FileMode.Create: 파일이 없다면 새로 생성해주고, 있으면 덮어씨운다.
        // .dat: 데이터(data)의 약어로 사용자가 정의한 데이터가 들어있는 파일의 확장자

        // <파일 쓰기>
        // 바이너리 파일을 쓸 때는 "BinaryWriter" 클래스 사용
        BinaryWriter binaryWriter = new BinaryWriter(fileStream);
        binaryWriter.Write("Hello.");
        binaryWriter.Write(593);
        binaryWriter.Close(); // 파일을 다 쓰면 꼭! 닫아줘야함!

        // 장점: 컴퓨터는 데이터를 0과 1 같은 바이너리 형태로 처리하므로
        // Binary를 사용하면 메모리를 좀 더 효율적으로 사용하고, 속도도 더 빠르다.

        // <파일 읽기>
        // 바이너리 파일을 읽을 때는 "BinaryReader" 클래스 사용
        fileStream = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open); // 다시 열기
        BinaryReader binaryReader = new BinaryReader(fileStream);

        Debug.Log(binaryReader.ReadString());
        Debug.Log(binaryReader.ReadInt32());
        binaryReader.Close();

    }
}

