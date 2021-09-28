using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ManageText : MonoBehaviour
{
    [SerializeField] private float m_timeToSwitchOff;
    [SerializeField] private Text m_text;
    private WaitForSeconds m_waitForSeceonds; // that's only for optimized, create one time not all the time when we push the button
    private void Start()
    {
        m_waitForSeceonds = new WaitForSeconds(m_timeToSwitchOff);
    }

    public void ShowText(Text text)
    {
        text.enabled = true; // of course I can make one method for all type of objects, like texture, panels ect,
                            // but this type of method is more optimized
                            
        StartCoroutine(HideTextObject());
    }
    
    
    private IEnumerator HideTextObject()
    {
        yield return m_waitForSeceonds;
        m_text.enabled = false;
    }
    
}
