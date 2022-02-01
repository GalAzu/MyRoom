using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public string songPlayed;
    private int songNumberInPlaylist;
    private TrackClass trackPlayed;
    public AudioSource audioSource;
    public TrackClass[] Playlist;
    public static AudioPlayer instance;
    [SerializeField]
    public static int trackID;
    private void UpdateAudioPlayer(string name , int id)
    {
        
    }
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        instance = this;
    }
    public void Play()
    {
        if(audioSource.clip != null && audioSource.isPlaying==false)
        audioSource.Play();
    }

    public void Stop()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
    }
    public void NextSong()
    {
        audioSource.clip = Playlist[songNumberInPlaylist++].audioClip;
        if (audioSource.isPlaying)
            audioSource.Stop();

        Invoke("Play", 1.5f);
    }
    public void PreviousSong()
    {
        audioSource.clip = Playlist[songNumberInPlaylist--].audioClip;
        if (audioSource.isPlaying)
            audioSource.Stop();

        Invoke("Play", 1.5f);
    }
    public void ChooseTrack()
    {
        audioSource.clip = Playlist[trackID].audioClip;
        songPlayed = audioSource.clip.name;
        PlayerController.instance.ReduceCoinsOnPlay();
    }
}

