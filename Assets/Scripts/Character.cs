using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Character: MonoBehaviour, ICharacter
    {
        public bool Main;
        public int place;
        public Button questB;
        private QuestCtrl _questCtrl;
        [SerializeField] private int _hp;
        [SerializeField] private int _st;
        [SerializeField] private int _hg;
        [SerializeField] private int _td;
        [SerializeField] private Image _hpSlider;
        [SerializeField] private Image _stSlider;
        [SerializeField] private Image _hgSlider;
        [SerializeField] private Image _tdSlider;

        private void Start()
        {
            _questCtrl = FindObjectOfType<QuestCtrl>();
            if (!Main)
            {
                questB.onClick.AddListener(OpenQuest); 
            }
            _hpSlider.fillAmount = _hp / 100f;
            _stSlider.fillAmount = _st / 100f;
            _hgSlider.fillAmount = _hg / 100f;
            _tdSlider.fillAmount = _td / 100f;
        }

        private void OpenQuest()
        {
         _questCtrl.ReciveChar(this);   
        }

        public int Health
        {
            get { return _hp;}
            set
            {
                if (value<0)
                {
                    value = 0;
                }
                if (value > 100)
                {
                    value = 100;
                }
                _hpSlider.fillAmount = value/ 100f ;
                _hp = value;
            }
        }
        public int Stress
        {
            get { return _st;}
            set
            {
                if (value<0)
                {
                    value = 0;
                }
                if (value > 100)
                {
                    value = 100;
                }
                _stSlider.fillAmount = value/ 100f ;
                _st = value;
            }
        }
        public int Hunger
        {
            get { return _hg;}
            set
            {
                if (value<0)
                {
                    value = 0;
                }
                if (value > 100)
                {
                    value = 100;
                }
                _hgSlider.fillAmount = value/ 100f ;
                _hg = value;
            }
        }
        public int Tired
        {
            get { return _td;}
            set
            {
                if (value<0)
                {
                    value = 0;
                }
                if (value > 100)
                {
                    value = 100;
                }
                _tdSlider.fillAmount = value/ 100f ;
                _td = value;
            }
        }

        public void SetHealth(int v)
        {
            Health +=v;
        }
        public void SetStress(int v)
        {
            Stress +=v;
        }
        public void SetHunger(int v)
        {
            Hunger +=v;
        }
        public void SetTired(int v)
        {
            Tired +=v;
        }
    }
}