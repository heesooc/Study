using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat 
{
    // 속성(멤버 변수)
    // 멤버 변수: 클래스에 소속된 '변수'
    public string Name; // 다른 곳에서 갖다쓰려면 public 써야함
    public int Age;
    public string FurColor;
    public string Species;
    private float _weight; //private(사적인) 멤버변수: _(언더바)+소문자 
    public bool WaterProperties;


    public Cat()
    {

    }


    public Cat(string name, int age, string furColor, string species, float weight, bool waterproperties)
    {
        Name = name;
        Age = age;
        FurColor = furColor;
        Species = species;
        _weight = weight;
        WaterProperties = waterproperties;
    }


    // 행동(멤버 함수)
    // 같은 클래스에 소속되어 있는 함수끼리는 조건 없이 호출 가능
    public void Jump() // 함수도 접근자 넣을 수 있다
    {
        Debug.Log($"내 이름 {Name}는 뛴다!");
    }

    public void Sleep() // 함수도 접근자 넣을 수 있다
    {
        Debug.Log($"나 {Name}는 잔다.zzz");
    }

    public void Meow() // 함수도 접근자 넣을 수 있다
    {
        Debug.Log($"나 {Name}는 야옹~");
    }


    public void Grooming(Cat otherCat)
    {
        Debug.Log($"{Name}는 {otherCat.Name}를 그루밍한다!");
    }

    public void Grooming(Dog otherDog)
    {
        Debug.Log($"{Name}는 {otherDog.Name}를 그루밍한다!");
    }
}
