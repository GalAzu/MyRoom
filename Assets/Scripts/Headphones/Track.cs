using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Track : MonoBehaviour
{
    public string trackName;
    public int trackNumber;
    public string information;
    public Image image;
    private void OnMouseDown()
    {
        AudioPlayer.trackID = trackNumber;
        AudioPlayer.instance.ChooseTrack();
    }

}
