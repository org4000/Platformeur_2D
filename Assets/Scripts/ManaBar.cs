using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey;
using System;

public class ManaBar : MonoBehaviour
{
    private Image barImage;

    public float manaAmount;
    public float manaRegenAmount;
    public float amount;


    public void Awake()
    {
        barImage = transform.Find("bar").GetComponent<Image>();
        manaAmount = 0;
        manaRegenAmount = 10f;
    }

    public void Update()
    {
        barImage.fillAmount = GetManaNormalized();

        if (Input.GetKeyDown(KeyCode.X))
        {
            TrySpendMana(30);
        }
        manaAmount += manaRegenAmount * Time.deltaTime;
        manaAmount = Mathf.Clamp(manaAmount, 0f, MANA_MAX);
    }
    public const int MANA_MAX = 100;

    public void TrySpendMana(int amount)
    {
        if (manaAmount >= amount)
        {
            manaAmount -= amount;
        }
    }


    public float GetManaNormalized()
    {
        return manaAmount / MANA_MAX;
    }
}