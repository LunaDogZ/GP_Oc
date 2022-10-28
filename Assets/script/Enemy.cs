using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] [Tooltip("Health of enemy")] int health;
    [SerializeField,Tooltip("Enemy's Movement Speed")] float speed;
    //[HideInspecter] = «èÍ¹¨Ò¡Ë¹éÒµèÒ§Inspec

    /// <summary>
    /// Method of enemy to reduce health point by assign damage
    /// </summary>
    /// <param name="damage">Value of damage that going to reduce health</param>
    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
