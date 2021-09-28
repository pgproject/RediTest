using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePanel : MonoBehaviour
{
    [SerializeField] private Animator m_anomator;
    
    public void SetTrigger(string nameTrigger)
    {
        m_anomator.SetTrigger(nameTrigger);
    }
}
