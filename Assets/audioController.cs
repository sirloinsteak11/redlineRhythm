using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioController : MonoBehaviour
{

    public float currentSongBPM, secPerBeat, songPosition, songPositionInBeats, dspSongTime, songBPM1, songBPM2;
    public Button exceeder;
    public Button ramune;
    public AudioSource musicSource;
    public AudioClip otherSong;
    public AudioClip firstSong;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = firstSong;
        initSong();
        musicSource.Play();

        exceeder.onClick.AddListener(changeRamune);
        ramune.onClick.AddListener(changeExceeder);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);
        songPositionInBeats = songPosition / secPerBeat;
    }

    void changeRamune() {
        Debug.Log("changing song to Ramune...");
        musicSource.clip = otherSong;
        currentSongBPM = songBPM2;
        initSong();
        musicSource.Play();
    }

    void changeExceeder() {
        Debug.Log("changing song to Exceeder...");
        musicSource.clip = firstSong;
        currentSongBPM = songBPM1;
        initSong();
        musicSource.Play();
    }

    void initSong() {
        if (musicSource.clip == firstSong) {
            currentSongBPM = songBPM1;
        } else if (musicSource.clip == otherSong) {
            currentSongBPM = songBPM2;
        }
        dspSongTime = (float)AudioSettings.dspTime;
        secPerBeat = 60f / currentSongBPM;
    }
}
