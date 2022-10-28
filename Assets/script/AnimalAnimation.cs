using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalAnimation : MonoBehaviour
{
    private Animator _anim;


    void Awake()
    {
        _anim = GetComponent<Animator>();

        /*
         * gameObject = ตัวเอง
         * GameObject = ประเภทตัวแปร
        */
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _anim.SetBool("isWalk", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            _anim.SetBool("isWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _anim.SetBool("isRun", true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            _anim.SetBool("isRun", false);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            _anim.SetBool("isFly", true);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            _anim.SetBool("isFly", false);
        }
        if (Input.GetMouseButtonDown(0))
        {
            _anim.SetTrigger("isAttack");
        }
    }
}
