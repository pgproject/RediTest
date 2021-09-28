using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Sounds : MonoBehaviour
{
   [SerializeField] private AudioSource m_audioSource;

   [SerializeField] private List<AudioClip> m_audioClips = new List<AudioClip>();
   private System.Random m_random = new System.Random();
   public void AddAudioSourceToList(AudioClip audioClip)
   {
      m_audioClips.Add(audioClip);
   }

   public void RemoveAudioSourceFromList(AudioClip audioClip)
   {
      m_audioClips.Remove(audioClip);
   }

   public void PlaySound()
   {
      if(!m_audioClips.Any()) return;

      int randomNumber = m_random.Next(0, m_audioClips.Count);

      m_audioSource.clip = m_audioClips[randomNumber];
      m_audioSource.Play();
   }


}
