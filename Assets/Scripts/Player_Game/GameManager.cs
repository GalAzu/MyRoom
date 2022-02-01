using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject book , chest , computer, musicPlayer;

    //Objects in room
    public void OpenCloseBook()
    {
        if (book.activeSelf == false)
            book.SetActive(true);
        else book.SetActive(false);
    }
    public void OpenCloseChest()
    {
        //set chest animation
        //
    }
    public void OpenCloseComputer()
    {
        if (computer.activeSelf == false)
            computer.SetActive(true);
        else computer.SetActive(false);
    }
    //In computer
    public void OpenMusicPlayer()
    {
        if (musicPlayer.activeSelf == false)
            musicPlayer.SetActive(true);
        else musicPlayer.SetActive(false);
    }


}
