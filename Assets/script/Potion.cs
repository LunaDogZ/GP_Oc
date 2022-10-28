using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Potion : MonoBehaviour
{
    [SerializeField] int power;
    [SerializeField] float duration;
    [SerializeField] Affect affect;
    [SerializeField] PotionType type;

    private Gp _Gp;

    private enum PotionType
    {
        Health,
        Mana,
        Poison,
    }


    private void UsePotion()
    {
        switch (type)
        {
            case PotionType.Health:
                affect.HealthBuff(power, duration);
                break;
            case PotionType.Mana:
                affect.ManaBuff(power, duration);
                break;
            case PotionType.Poison:
                affect.PoisonBuff(power, duration);
                break;
        }
    }

    private void Awake()
    {
        _Gp = new Gp();   
    }

    private void OnEnable()
    {
        _Gp.Enable();
    }

    private void OnDisable()
    {
        _Gp.Disable();
    }

    private void Start()
    {
        _Gp.Player.interact.started += _ => UsePotion();

    }
}
