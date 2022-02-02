using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_ : MonoBehaviour
{
    public enum button { IncreaseVol , DecreaseVol , Mute , Previous , Forward}
    public button _button;
    private void OnMouseDown()
    {
        switch(_button)
        {
            case (button.IncreaseVol):
                AudioPlayer.instance.RaiseVolume();
                break;
            case (button.DecreaseVol):
                AudioPlayer.instance.LowerVolume();
                break;
            case (button.Mute):
                AudioPlayer.instance.MuteAudio();
                break;
            case (button.Previous):
                AudioPlayer.instance.PreviousSong();
                break;
            case (button.Forward):
                AudioPlayer.instance.NextSong();
                break;
        }
    }
}
