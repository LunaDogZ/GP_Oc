using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public Rigidbody arrowModel;

    public float maxPower;
    public float chargePower;
    public float chargeSpeed;

    public bool isCharge;

    void Update()
    {
        //คลิก
        if(Input.GetMouseButtonDown(0))
        {
            isCharge = true;
        }
        //ยังคลิกอยู่
        if(isCharge && chargePower <= maxPower)
        {
            chargePower += chargeSpeed* Time.deltaTime;
        }
        //ปล่อย
        if(isCharge && Input.GetMouseButtonUp(0))
        {
            Rigidbody shotArrow = Instantiate(arrowModel, transform.position, transform.rotation);
            shotArrow.AddForce(transform.forward * chargePower, ForceMode.Impulse);
            chargePower = 0f;
            isCharge = false;
        }
    }
}
