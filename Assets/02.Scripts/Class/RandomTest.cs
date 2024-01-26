using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    void Start()
    {
        // UnityEngine.Random 클래스 : 난수 생성과 관련있는 클래스
        // 난수: 정의된 범위 내에서 무작위로 추출된 수 (=랜덤값)

        //UnityEngine.Random.InitState(13); //공통출력:70 //initState()
                                          //즉 처음 한 번만 호출되고 호출되지 않는다는 뜻
        Debug.Log(UnityEngine.Random.Range(0, 100)); //마지막 수 출력X. 
        //Debug.Log(UnityEngine.Random.Range(0f, 100f)); //함수 오버로드 //float 마지막 수 출력O
        //같은 알고리즘을 쓰고 있어도 시드 값에 따라 다르게 나옴. 시작 숫자를 시드(seed)라고하고 환경,시간 나노단위 영향받음. 
    }


}
