using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NumberRun
{
    [RequireComponent(typeof(Collider))]
    public class SurfaceSlider : MonoBehaviour
    {
        #region Variabels
        [SerializeField] private bool m_drawDebug = true;
        private Vector3 m_normal;
        #endregion

        /// <summary>Project vector to last contact surface</summary>
        public Vector3 Project(Vector3 vector)
        {
            return vector - Vector3.Dot(vector, m_normal) * m_normal;
        }

        private void OnCollisionEnter(Collision other)
        {
            m_normal = other.contacts[0].normal;
        }

        private void OnDrawGizmos()
        {
            if (m_drawDebug)
            {
                //cache vars
                var curColor = Gizmos.color;
                var curPos = transform.position;

                Gizmos.color = Color.white;
                Debug.DrawLine(transform.position, curPos + m_normal * 3);

                Gizmos.color = Color.red;
                Debug.DrawLine(transform.position, curPos + Project(transform.forward) * 3);

                Gizmos.color = curColor;
            }
        }
    }
}