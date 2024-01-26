using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SerializationExample : MonoBehaviour
{
    // 직렬화(Serialization)
    // 메모리에 저장된 객체를 파일에 저장하기 좋은 형태로 가공하는 것

    private void Start()
    {
        // 테스트용 객체 생성
        Human human = new Human();
        human.Name = "조희수";
        human.Age = 25;

        // <파일 열기>
        FileStream fileStream = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Create);

        // <파일 쓰기>
        // 객체를 파일로 쓸 때는 "BinaryFormatter" 클래스 사용
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(fileStream, human);
        fileStream.Close();

        // <파일 읽기>
        // 파일로부터 객체를 읽어 올 때 "BinaryFormatter" 클래스 사용
        fileStream = new FileStream("C:/Users/USER/Desktop/test.txt", FileMode.Open);
        Human h = binaryFormatter.Deserialize(fileStream) as Human; //역직렬화하다
        if (h != null)
        {
            Debug.Log(h.Name);
            Debug.Log(h.Age);
        }

    }
}

[System.Serializable]
public class Human
{
    public string Name;
    public int Age;
}
