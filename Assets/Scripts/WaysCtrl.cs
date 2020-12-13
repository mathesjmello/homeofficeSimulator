using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaysCtrl : MonoBehaviour
{
    public StatsButton[] waysB;
    
    public void RecivePlace(int i)
    {
        foreach (var way in waysB)
        {
            switch (i)
            {
                case 1 :
                    way.Hp = true;
                    way.Hg = false;
                    way.St = false;  
                    way.Money = false;
                    break;
                case 2:
                    way.Hp = false;
                    way.Hg = true;
                    way.St = false;  
                    way.Money = false;
                    break;
                case 3:
                    way.Hp = false;
                    way.Hg = false;
                    way.St = true;  
                    way.Money = false;
                    break;
                case 4:
                    way.Hp = false;
                    way.Hg = false;
                    way.St = false;  
                    way.Money = true;
                    break;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
