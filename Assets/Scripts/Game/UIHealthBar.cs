using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    private Slider _healthBar;

    private void Awake()
    {
        _healthBar = GetComponent<Slider>();
    }

    private void Update()
    {

    }

    public void SetValue(int health)
    {
        _healthBar.value = health;
    }

    public void SetMax(int maxHealth)
    {
        _healthBar.maxValue = maxHealth;
        SetValue(maxHealth);
    }
}
