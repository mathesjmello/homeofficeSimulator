using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceButton : MonoBehaviour
{
    public int place;
    private Button btn;
    public WaysCtrl ways;
    
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        
        btn.onClick.AddListener(CallWays);
    }

    private void CallWays()
    {
        if(!ways.gameObject.activeSelf) ways.gameObject.SetActive(true);
        ways.RecivePlace(place);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
