using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  private AudioSource _audioSource;

  private void PlayMusic()
  {
    _audioSource.Play();
  }
}
