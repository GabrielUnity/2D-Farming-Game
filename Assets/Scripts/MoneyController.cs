﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyController : MonoBehaviour
{
    public long money;
    public Text moneyText; 

    void Start()
    {
        money = 1100;
    }

    void Update()
    {
        moneyText.text = formatMoney(money);
    }

    public void addMoney(long moneyToAdd)
    {
        money += moneyToAdd;
    }

    public void substractMoney(long moneyToSubstract)
    {
        if(money - moneyToSubstract < 0)
        {
            Debug.Log("Cannot substract money !");
        }
        else
        {
            money -= moneyToSubstract;
        }
    }

    private string formatMoney(long moneyToFormat)
    {
        string suffix;
        if (moneyToFormat < 1000l)
        {
            moneyToFormat = moneyToFormat;
            suffix = "";
        }
        else if (moneyToFormat < 1000000l)
        {
            moneyToFormat = moneyToFormat / 1000l;
            suffix = "K";
        }
        else if (moneyToFormat < 1000000000l)
        {
            moneyToFormat = moneyToFormat / 1000000l;
            suffix = "M";
        }
        else
        {
            moneyToFormat = moneyToFormat / 1000000000l;
            suffix = "B";
        }
        return moneyToFormat.ToString() + suffix;
    }
}