using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StatsButton : MonoBehaviour
{
    
    
    public bool Hp, St, Hg, Td, Money,Spend;
    public int Power=10;
    public Character Char;
    private WorkMng _workMng;
    
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(ResultStats);
        _workMng=FindObjectOfType<WorkMng>();
        
    }

    private void ResultStats()
    {
        if (Hp)
        {
            _workMng.AddHours(Power/10);
            Char.SetHealth(Power);
        }

        if (St)
        {
            _workMng.AddHours(Power/10);
            Char.SetStress(Power);
            Char.SetTired(Power/2);
            Char.SetHunger(-Power/2);
        }

        if (Hg)
        {
            _workMng.AddHours(Power/10);
            Char.SetHunger(Power);
            Char.SetTired(-Power/2);
        }

        if (Td)
        {
            _workMng.AddHours(Power/10);
            Char.SetTired(Power*2);
            Char.SetStress(Power/2);
            Char.SetHunger(-Power);
        }

        if (Money)
        {
            _workMng.EarnMoney(Power);
            _workMng.AddHours(Power/10);
            Char.SetStress(-Power);
            Char.SetHunger(-Power/2);
            Char.SetTired(-Power);
        }

        if (Spend)
        {
            _workMng.EarnMoney(Power-100);
        }
    }
}

