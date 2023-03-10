using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private AudioSource audioManager;
    [SerializeField] private GameObject audioButton, rotationTable;
    [SerializeField] private Sprite offSprite, onSprite;
    public bool cameraCanFollow;
    //[SerializeField] private GameObject mainCamera;
    public bool isOnisOf = false;
    private void Awake()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1f;
        cameraCanFollow = true;//KAMERA OKU TAKÝP EDEBÝLÝR
        //mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, new Vector3(0, 0, 0), 4f);
    }
    public void ThemeSongOnOff()
    {
        isOnisOf = !isOnisOf;
        if (isOnisOf == true)
        {
            audioManager.GetComponent<AudioSource>().Stop();
            audioButton.GetComponent<Image>().sprite = offSprite;
        }
        if (isOnisOf == false)
        {
            audioManager.GetComponent<AudioSource>().Play();
            audioButton.GetComponent<Image>().sprite = onSprite;
        }
    }
    public void NextObjectRight()
    {
        rotationTable.transform.position += new Vector3(- 3f, 0, 0);
    }
    public void NextObjectLeft()
    {
        rotationTable.transform.position += new Vector3(3f, 0, 0);
    }
    
}
