using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundClass : MonoBehaviour
{   
    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        StartCoroutine(StopAudio());
    }
 
    public void PlaySound()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }
 
    public void StopSound()
    {
        _audioSource.Stop();
    }

    System.Collections.IEnumerator StopAudio()
    {
        yield return new WaitForSeconds(81);
        StopSound();
    }
}
