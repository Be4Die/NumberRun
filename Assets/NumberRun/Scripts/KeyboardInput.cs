using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NumberRun
{
    public static class Axis
    {
        public static readonly string Horizontal = "Horizontal";
        public static readonly string Vertical = "Vertical";
    }

    public class KeyboardInput : MonoBehaviour
    {
        [SerializeField] private PhysicsMovement m_movement;

        private void Update()
        {
            var horizontal = Input.GetAxis(Axis.Horizontal);

            m_movement.DirictionMove(new Vector3(horizontal, 0, 1));
        }
    }
}