using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ����: ���� ������ �ʿ��� ������(�̸�, ����)���� �����ϰ� ����ϱ� ���� �������� '����'
        // (�ܼ��ϰ� �̸�, ���� ���� ������ �Ӹ� �ƴ϶� ȭ�鿡 ���̴� �̹���, ���� ��
        // ���ӿ� �ʿ��� ��� �����͸� ������ �� �ִ�.)

        // ����: ������ ����� ��(�����͸� ������ ���� Ȯ��)
        // 1. �����͸� Ȱ���ϴ� ����
        // 2. �������� Ÿ��(����, ����)
        // 3. �����͸� �θ��� �̸� (������)
        // �ʼ�: 2, 3
        // <������ Ÿ��> <������>

        // integer(����)
        // ���� Ÿ��: ����: -2, -1, 0, 1, 2 ... , 2312 �� ���� �Ҽ����� ���� ����
        int age = 20;

        // float (�Ǽ�)
        // ���� Ÿ��: �ε��Ҽ���: -2.132, -1.34, 0.0, 123.23 �� ���� �Ҽ����� �ִ� ����
        float height = 185.2f;

        // string (���ڿ�)
        // ���ڿ�: ������ ����(����)
        string name = "�����";

        // bool (��)
        // �� Ÿ��: ��(true) ����(false)
        bool isMan = false;

        Debug.Log(age);
        Debug.Log(height);
        Debug.Log(name);
        Debug.Log(isMan);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
