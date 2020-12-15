using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkMng : MonoBehaviour
{
    public int money;
    public Text moneyT, hourT;
    public int time=6;
    
    // Start is called before the first frame update
    void Start()
    {
        moneyT.text = money.ToString();
        hourT.text = time.ToString("00");
    }

    public void EarnMoney(int m)
    {
        money += m;
        if (money<0)
        {
            money = 0;
        }
        moneyT.text = money.ToString();
    }

    public void AddHours(int h)
    {
        time += h*2;
        if (time>24)
        {
            time = time - 24;
        }

        hourT.text = time.ToString("00");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
