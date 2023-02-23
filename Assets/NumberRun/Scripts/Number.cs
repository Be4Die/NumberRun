using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace NumberRun
{
    public class Number : MonoBehaviour
    {
        #region Variabels
        public Action OnValueChanged;

        public int Value { get => m_value; }
        [SerializeField] private int m_value;
        #endregion

        private void Awake()
        {
            SetValue(m_value);
        }

        public void AddValue(int amount)
        {
            m_value += amount;
            OnValueChanged?.Invoke();
        }

        public void SetValue(int value)
        {
            m_value = value;
            OnValueChanged?.Invoke();
        }
    }
}