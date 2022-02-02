using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compter : MonoBehaviour
{
    public Software[] hardDrive;
    public Software softwareRunning;
    public GameObject computerUI;

    private void OnMouseDown()
    {
        TriggerComUI();
    }
    
    public void TriggerComUI()
    {
        if (computerUI.activeSelf == true) computerUI.SetActive(false);
        else computerUI.SetActive(true);
    }
}
