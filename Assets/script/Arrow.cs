using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    //��С�ȵ������ Rigidbody �ͧ����١����ͧ
    //Rigidbody ��� Component ���˹�觷����㹡�ú͡ Unity ���ӹǹ Physics �Ѻ�ѵ�ت�鹹�� � 
    private Rigidbody _rb;

    //��������������㹵͹�á�ش (Awake �ӧҹ ��͹ Start)
    private void Awake()
    {
        //��˹�������÷���ժ������ _rb ��� Rigidbody �ͧ�ѵ�ط����� Script ������
        _rb = GetComponent<Rigidbody>();
    }

    //�ӧҹ������ �
    void Update()
    {
        //��˹��������ع�ͧ�ѵ�ت�鹹�� = ��ع价��ͧ�ҵ�� ������� �ͧ _rb
        transform.rotation = Quaternion.LookRotation(_rb.velocity);
    }
}