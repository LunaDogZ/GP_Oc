using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Melee : MonoBehaviour
{
    [SerializeField] float distance;
    [SerializeField] int damage;
    [SerializeField] Transform face;

    private RaycastHit _hit;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(face.position, face.forward, out _hit, distance))
            {
                if (_hit.transform.tag == "Enemy")
                {
                    Enemy enemy;
                    _hit.transform.TryGetComponent(out enemy);

                    enemy.TakeDamage(damage);
                }
            }
        }
    }
}
