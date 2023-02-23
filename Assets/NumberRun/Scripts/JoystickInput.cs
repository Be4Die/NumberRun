using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NumberRun
{
    public class JoystickInput : MonoBehaviour
    {
        [SerializeField] private Joystick m_joystick;
        [SerializeField] private PhysicsMovement m_movement;

        private void Update() {
            m_movement.DirictionMove(new Vector3(m_joystick.Horizontal, 0, 1));
        }
    }
}