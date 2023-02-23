using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NumberRun
{
    [RequireComponent(typeof(Number))]
    public class NumberTrigger : MonoBehaviour
    {
        public Number Number { get => m_number; }
        private Number m_number;
        private void Awake() {
            m_number = GetComponent<Number>();
        }
    }
}
