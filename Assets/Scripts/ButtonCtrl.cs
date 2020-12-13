using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCtrl : MonoBehaviour
{
    public GameObject ativavel;
    
    private Button _btn;

    private void Start()
    {
        _btn = GetComponent<Button>();
        _btn.onClick.AddListener(OnPainel);
    }

    private void OnPainel()
    {
        var b = !ativavel.activeSelf;
        ativavel.SetActive(b);
        
    }
}
