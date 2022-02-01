using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour
{
    public string trackName;
    public int trackNumber;


    private void OnMouseDown()
    {
        AudioPlayer.trackID = trackNumber;
    }
}
