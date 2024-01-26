using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    // 변수 이름은 의미있게
    // 표기법: "파스칼케이스" = 첫글자를 대문자로 시작


    [Header("이름")]
    public string CharacterName = "시즈땡크";
    [Header("직업")]
    public string Job = "메카닉";
    [Header("길드")]
    public string Guild = "순애";
    [Header("모자")]
    public string Hat = "브로콜리";
    [Header("무기")]
    public string Weapon = "포크";

    [Header("이동속도")]
    public int MoveSpeed = 140;
    [Header("방어력")]
    public int Defense = 60243;
    [Header("점프력")]
    public int JumpingPower = 123;
    [Header("공격속도")]
    public int AttackSpeed = 8;
    [Header("마력")]
    public int HorsePower = 2000;

    [Header("공격력")]
    public float Damage = 107.00f;
    [Header("최종데미지")]
    public float FinalDamage = 52.90f;
    [Header("보스몬스터데미지")]
    public float BossMonDamage = 428.00f;
    [Header("방어율무시")]
    public float DefenseIgnore = 95.90f;
    [Header("크리데미지")]
    public float CriticalDamage = 82.55f;

    void Start()
    {
        Debug.Log("이름: " + CharacterName);
        Debug.Log("직업: " + Job);
        Debug.Log("길드: " + Guild);
        Debug.Log("모자: " + Hat);
        Debug.Log("무기: " + Weapon);

        Debug.Log("이동속도: " + MoveSpeed);
        Debug.Log("방어력: " + Defense);
        Debug.Log("점프력: " + JumpingPower);
        Debug.Log("공격속도: " + AttackSpeed);
        Debug.Log("마력: " + HorsePower);

        Debug.Log("공격력: " + Damage);
        Debug.Log("최종데미지: " + FinalDamage);
        Debug.Log("보스몬스터데미지: " + BossMonDamage);
        Debug.Log("방어율무시: " + DefenseIgnore);
        Debug.Log("크리데미지: " + CriticalDamage);

    }

    
    void Update()
    {
        
    }
}
