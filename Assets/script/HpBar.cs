using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HpBar : MonoBehaviour
{
    [SerializeField] TMP_Text textDP;
    [SerializeField] Slider _slider;

    private int maxValue;

    public void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void SetUp(int maxvalue)
    {
        this.maxValue = maxvalue;
        _slider.maxValue = maxvalue;
        _slider.value = maxvalue;

        Setvalue(maxvalue);
    }

    public void Setvalue(int value)
    {
        _slider.value = value;

        string p = value + "/" + maxValue;

        //textDP.text = value + "/" + maxValue;
        //textDP.text = $"{value} / {maxValue}";
        textDP.text = p;
    }
}
