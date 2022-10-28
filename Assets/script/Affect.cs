using System.Collections;
using UnityEngine;

public class Affect : MonoBehaviour
{
   
    [SerializeField] private Stat stat;
    
    [Header("Health Relate Effect")] 
    
    
    [SerializeField] private float timeBetweenHeal;
    [SerializeField] float timeBetweenPoison;
    [SerializeField] float timeBetweenMana;


    private Coroutine _healthFX;
    private Coroutine _poisonFX;
    private Coroutine _manaFX;

    private float _healthFXDuration; 
    private bool _healthFXInProgress; 

    private float _poisonFXDuration;
    private bool _poisonFXInProgress;

    private float _manaFXDuration;
    private bool _manaFXInProgress;


    private void Update()
    {
        if (_healthFXInProgress) _healthFXDuration += Time.deltaTime;
        if (_poisonFXInProgress) _poisonFXDuration += Time.deltaTime;
        if (_manaFXInProgress) _manaFXDuration += Time.deltaTime;
    }


    public void HealthBuff(int power, float limiter)
    {
        if(_healthFX != null) StopCoroutine(_healthFX);
        

        _healthFX = StartCoroutine(Adrenaline(limiter, timeBetweenHeal, power));
    }

    public void PoisonBuff(int power, float limiter)
    {
        if(_poisonFX !=null) StopCoroutine(_poisonFX);
        _poisonFX = StartCoroutine(Poison(limiter, timeBetweenPoison, power));
    }

    public void ManaBuff(int power, float limiter)
    {
        if(_manaFX !=null) StopCoroutine(_manaFX);
        _manaFX = StartCoroutine(Mana(limiter, timeBetweenMana, power));
    }

 
    IEnumerator Adrenaline(float limiter, float timeBetweenFX, int power)
    {
        _healthFXDuration = 0f;
        _healthFXInProgress = true; 

        while (_healthFXDuration <= limiter)
        {
            stat.CalculateHealth(power);          
            yield return new WaitForSeconds(timeBetweenFX);
        }
        _healthFX = null;        
      
        _healthFXInProgress = false;
    }
    IEnumerator Poison(float limiter, float timeBetweenFX, int power)
    {
        _poisonFXDuration = 0f; 
        _poisonFXInProgress = true; 

        while (_poisonFXDuration <= limiter)
        {
            stat.CalculatePoison(power);

            yield return new WaitForSeconds(timeBetweenFX);
        }

        _poisonFX = null;

        _poisonFXInProgress = false;
    }

    IEnumerator Mana(float limiter, float timeBetweenFX, int power)
    {
        _manaFXDuration = 0f;
        _manaFXInProgress = true;

        while (_manaFXDuration <= limiter)
        {
            stat.CalculateMana(power);

            yield return new WaitForSeconds(timeBetweenFX);
        }

        _manaFX = null;
        _manaFXInProgress = false;
    }
}
