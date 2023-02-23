using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NumberRun
{
    [RequireComponent(typeof(Rigidbody))]
    public class PhysicsMovement : MonoBehaviour
    {
        #region Variabels
        [SerializeField] private float m_speed = 10f;
        [SerializeField] private SurfaceSlider m_surfaceSlider;

        private Rigidbody m_rigidbody;
        #endregion

        private void Awake()
        {
            m_rigidbody = GetComponent<Rigidbody>();
        }

        public void DirictionMove(Vector3 direction)
        {
            var directionAlongSurface = m_surfaceSlider.Project(direction.normalized);
            var offset = directionAlongSurface * (m_speed * Time.deltaTime);

            m_rigidbody.MovePosition(m_rigidbody.position + offset);
        }
    }
}
