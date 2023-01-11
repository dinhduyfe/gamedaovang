using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public GameObject prefabs;

    public AudioClip nhacnen;
    private AudioSource nhacnenSource;
    public AudioClip thaday;
    private AudioSource thadaySource;
    public AudioClip keoday;
    private AudioSource keodaySource;
    public AudioClip congtien;
    private AudioSource congtienSource;
    public AudioClip demgio;
    private AudioSource demgioSource;
    public AudioClip win;
    private AudioSource winSource;
    public AudioClip fail;
    private AudioSource failSource;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    public void PlaySound(AudioClip clip, float volume, bool isLoopback)
    {
        if(clip == this.nhacnen)
        {
            Play(clip, ref nhacnenSource, volume, isLoopback);
        }
    }

    public void PlaySound(AudioClip clip, float volume)
    {
        if (clip == this.congtien)
        {
            Play(clip, ref congtienSource, volume);
        }
        if (clip == this.keoday)
        {
            Play(clip, ref keodaySource, volume);

        }
        if (clip == this.thaday)
        {
            Play(clip, ref thadaySource, volume);

        }
        if (clip == this.demgio)
        {
            Play(clip, ref demgioSource, volume);

        }
        if (clip == this.win)
        {
            Play(clip, ref winSource, volume);

        }
        if (clip == this.fail)
        {
            Play(clip, ref failSource, volume);

        }
    }

    private void Play(AudioClip clip, ref AudioSource audioSource, float volume, bool isLoopback = false)
    {
        if (audioSource == null)
        {
            audioSource = Instantiate(instance.prefabs).GetComponent<AudioSource>();
            audioSource.clip = clip;
            audioSource.volume = volume;
            audioSource.loop = true;
            audioSource.Play();
            Destroy(audioSource.gameObject, audioSource.clip.length);
        }
    }
    public void StopSound(AudioClip clip)
    {
        if (clip == this.thaday && thadaySource!=null)
        {
            thadaySource.Stop();
            Destroy(thadaySource.gameObject);
        }
        if (clip == this.keoday && keodaySource != null)
        {
            keodaySource.Stop();
            Destroy(thadaySource.gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
