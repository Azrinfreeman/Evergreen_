using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLoopingController : MonoBehaviour
{
    public static MusicLoopingController instance;

    void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public List<AudioSource> audioSources;
    public int currentAudio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentAudio = 0;
        audioSources[currentAudio].Play();
    }

    // Update is called once per frame

    public void CheckForLoopingAudio()
    {
        audioSources[0].time = audioSources[0].clip.length;
    }

    void Update()
    {
        if (
            audioSources[currentAudio].time >= audioSources[currentAudio].clip.length
            && !audioSources[currentAudio].isPlaying
        )
        {
            currentAudio++;

            if (currentAudio > audioSources.Count - 1)
            {
                currentAudio = 0;
                audioSources[currentAudio].Play();
            }
            else
            {
                audioSources[currentAudio].Play();
            }
        }
    }
}
