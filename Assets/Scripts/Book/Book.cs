using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Book : MonoBehaviour
{
    [Range(1, 4)] public int pageNumber;
    [SerializeField]
    public List<PageClass> pages;
    [SerializeField]
    public PageClass curPage;
    private AudioSource audioSource;
    [SerializeField] private float interactionDistance;
    private PlayerController Player;
    public static Book instance;
    [SerializeField] private TextMeshProUGUI header, text;
    private Image pageImage;


    public int tryout { get; set; }

    private void Awake()
    {
        instance = this;
        Player = FindObjectOfType<PlayerController>();
        
    }
    private void Start()
    {
        curPage = pages[pageNumber - 1];
        UpdatePage();
    }

    public void ShowPage()
    {
        if(Vector3.Distance(Player.transform.position , transform.position) < interactionDistance)
        {
            UpdatePage();
        }
    }
    public void NextPage()
    {
        curPage = pages[curPage.pageNumber++];
        UpdatePage();
    }
    public void BeforePage()
    {
        curPage = pages[curPage.pageNumber--];
        UpdatePage();
    }
    public void UpdatePage()
    {
        header.text = curPage.header;
        text.text = curPage.text;
        if (curPage.audio != null)
        {
            audioSource.clip = curPage.audio;
            audioSource.Play();
        }
        else if (curPage.image != null) 
            pageImage = curPage.image;
    }

}
