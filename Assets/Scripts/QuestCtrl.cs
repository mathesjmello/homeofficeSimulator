using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class QuestCtrl : MonoBehaviour
{
    public Sprite[] sprits;
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
    }

    private void SetQuestData()
    {
        _hpSlider.fillAmount = personData.Health/100f;
        _stSlider.fillAmount = personData.Stress/100f;
        _hgSlider.fillAmount = personData.Hunger/100f;
        _tdSlider.fillAmount = personData.Tired/100f;
        switch (personData.place)
        {
            case 0:
                Char.sprite = sprits[0];
                break;
            case 1:
                Char.sprite = sprits[1];
                break;
            case 2:
                Char.sprite = sprits[2];
                break;
            case 3:
                Char.sprite = sprits[3];
                break;
            case 4:
                Char.sprite = sprits[4];
                break;
            case 5:
                Char.sprite = sprits[5];
                break;
            case 6:
                Char.sprite = sprits[6];
                break;
            case 7:
                Char.sprite = sprits[7];
                break;
            
        }
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
