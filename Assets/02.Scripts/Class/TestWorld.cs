using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWorld : MonoBehaviour
{
    
    void Start()
    {
        
        Cat cat1 = new Cat("야옹이", 10, "빨간색", "페르시안", 5f, true);
        cat1.Jump();
        cat1.Sleep();
        cat1.Meow(); 

        Cat cat2 = new Cat();

        cat2.Name = "귀요미";
        cat2.Age = 2;
        cat2.FurColor = "오렌지색";
        cat2.Species = "샴";
        cat2.WaterProperties = true;

        cat2.Jump();
        cat2.Sleep();
        cat2.Meow();


        Dog dog1 = new Dog("댕댕이", 8, "갈색", "셰퍼드", 5.5f);
        dog1.Jump();
        dog1.Sleep();
        dog1.Woof();

        Dog dog2 = new Dog();
        dog2.Name = "해피";
        dog2.Age = 1;
        dog2.FurColor = "하얀색";
        dog2.Species = "비숑";

        dog2.Jump();
        dog2.Sleep();
        dog2.Woof();

        cat1.Grooming(cat2);
        cat1.Grooming(dog1);
        dog1.Bite(dog2);
        dog1.Bite(cat1);
    }


}
