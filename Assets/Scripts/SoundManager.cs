using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource efxSource;
    public AudioSource musicSource;
    public AudioSource gameOver;
    public static SoundManager instance = null;

    public float lowPitchRange = .95f;
    public float highPitchRange = 1.05f;


    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void PlaySingle(AudioClip clip) {
        efxSource.clip = clip;
        efxSource.Play();
    }
    
    public void SetBGMVolume(float num) {
        musicSource.volume = num;
    }

    public void PauseBGM() {
        musicSource.Pause();
    }

    public void ResumeBGM() {
        musicSource.UnPause();
    }

    public void PlayBGM(){
        musicSource.Play();
    }

    public void PlayGameOver(){
        gameOver.Play();
    }


    

   
}
