using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    [SerializeField] HpBar HpBar;
    [SerializeField] int maxHealth;
    [SerializeField] int maxMana;
    private int _health; 
    private int _mana;

    private void Awake()
    {
        _health = maxHealth;
        _mana = maxMana;
        HpBar.SetUp(maxHealth);
    }

    public void CalculateHealth(int value)
    {
 
        _health += value;

        if (_health >= maxHealth) _health = maxHealth;
        else if (_health <= 0) _health = 0;

        HpBar.Setvalue(_health);

    }

    public void CalculatePoison(int value)
    {
        _health -= value;
        if (_health <= 0) _health = 0;
        HpBar.Setvalue(_health);

    }

    public void CalculateMana(int value)
    {
        _mana += value;
        if(_mana >= maxMana) _mana = maxMana;
        else if (_mana <= 0) _mana = 0;
    }
    #region Debug

    [ContextMenu("Health/Set Health to One")]
    private void SetHealthToOne()
    {
        _health = 1;

        HpBar.Setvalue(_health);
    }

    #endregion

    #region Debug

    [ContextMenu("Mana/Set Mana to One")]
    private void SetManaToOne()
    {
        _mana = 1;
    }

    #endregion
}


