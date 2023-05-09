using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey;
using System;

public class ManaBar : MonoBehaviour
{
    public Mana mana;
    private Image barImage;

    public void Awake()
    {
        barImage = transform.Find("bar").GetComponent<Image>();

        mana = new Mana();

    }

    public void Update()
    {
        mana.Update();

        barImage.fillAmount = mana.GetManaNormalized();

        if (Input.GetKeyDown(KeyCode.X))
        {
            mana.TrySpendMana(30);
        }
    }

    
}


public class Mana
{
    public const int MANA_MAX = 100;

    public float manaAmount;
    public float manaRegenAmount;
    public float amount;

    

    public Mana()
    {
        manaAmount = 0;
        manaRegenAmount = 10f;
    }


    public void Update()
    {
        manaAmount += manaRegenAmount * Time.deltaTime;
        manaAmount = Mathf.Clamp(manaAmount, 0f, MANA_MAX);
    }


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
