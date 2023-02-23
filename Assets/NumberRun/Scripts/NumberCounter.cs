using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NumberRun
{
    [RequireComponent(typeof(Collider))]
    [RequireComponent(typeof(Rigidbody))]
    public class NumberCounter : MonoBehaviour
    {
        #region Variabels
        [SerializeField] private Number m_number;
        #endregion
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<NumberTrigger>(out var trigger))
            {
                m_number.AddValue(trigger.Number.Value);
                Destroy(trigger.gameObject);
            }
        }
    }
}