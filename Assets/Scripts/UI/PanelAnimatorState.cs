using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAnimatorState : MonoBehaviour
{
    [SerializeField] private Animator m_animator;
    private void OnDisable()
    {
        m_animator.Rebind();
    }
}
