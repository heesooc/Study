using UnityEngine;

// 보간: 시작점과 끝점이 주어졌을 때 두 점 사이의 진행률(비율)에 따라 그 사이의 특정한 지점을 얻는 것
// 진행률(비율) -> 0 ~ 1 사이의 값
// 뭔가를 "부드럽게" 할 때 사용

// 선형보간(Lerp: Linear Interpolation) ->
// "직선": 균일한 속도로 이동시키거나 회전시킬 때 사용

public class LerpExample : MonoBehaviour
{
    public Transform Start;
    public Transform End;

    public float Duration = 3f; // 지속시간

    private float _progress; // 진행률: 0 ~ 1


    void Update()
    {
        _progress += Time.deltaTime / Duration;
        // Vector3.Lerp(시작 좌표, 종료 좌표, 진행률)
        transform.position = Vector3.Lerp(Start.position, End.position, _progress);
    }
}
