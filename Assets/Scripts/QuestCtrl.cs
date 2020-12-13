using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class QuestCtrl : MonoBehaviour
{
    public GameObject lastChar;
    public Character personData;
    public Image Char;
    public GameObject questPainel;
    [SerializeField] private Image _hpSlider;
    [SerializeField] private Image _stSlider;
    [SerializeField] private Image _hgSlider;
    [SerializeField] private Image _tdSlider;
    public Button hp, st, hg, td;
    
    public void ReciveChar(Character _char)
    {
        personData = _char;
        SetQuestData();
        questPainel.SetActive(true);
        lastChar = _char.gameObject;
    }

    private void SetQuestData()
    {
        _hpSlider.fillAmount = personData.Health/100f;
        _stSlider.fillAmount = personData.Stress/100f;
        _hgSlider.fillAmount = personData.Hunger/100f;
        _tdSlider.fillAmount = personData.Tired/100f;
        //Char.sprite = personData.Char.sprite;
    }

    // Start is called before the first frame update
    void Start()
    {
        hp.onClick.AddListener(HelpHp);
        st.onClick.AddListener(HelpSt);
        hg.onClick.AddListener(HelpHg);
        td.onClick.AddListener(HelpTd);
    }

    private void HelpTd()
    {
        personData.SetTired(40);
        questPainel.SetActive(false);
    }

    private void HelpHg()
    {
        personData.SetHunger(40);
        questPainel.SetActive(false);
    }

    private void HelpSt()
    {
        personData.SetStress(40);
        questPainel.SetActive(false);
    }

    private void HelpHp()
    {
        personData.SetHealth(40);
        questPainel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
