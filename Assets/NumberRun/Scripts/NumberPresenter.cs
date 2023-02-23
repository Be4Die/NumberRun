using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NumberRun
{
    [RequireComponent(typeof(Number))]
    public class NumberPresenter : MonoBehaviour
    {
        [SerializeField] private Text m_textGUI;
        private Number m_number;

        private void Awake() {
            m_number = GetComponent<Number>();
            UpdateText();
        }

        private void OnEnable()
        {
            m_number.OnValueChanged += () => UpdateText();
        }

        private void OnDisable() {
            m_number.OnValueChanged -= () => UpdateText();
        }
        

        public void UpdateText()
        {
            m_textGUI.text = m_number.Value.ToString();
        } 
    }
}
