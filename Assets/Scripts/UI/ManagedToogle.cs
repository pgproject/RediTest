using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagedToogle : MonoBehaviour
{
    [SerializeField] private Toggle m_toogle;
    [SerializeField] private Sounds m_sounds;

    public void ClickToggle(AudioClip audioClip)
    {
        if(m_toogle.isOn)
            m_sounds.AddAudioSourceToList(audioClip);
        else
            m_sounds.RemoveAudioSourceFromList(audioClip);
    }

}
