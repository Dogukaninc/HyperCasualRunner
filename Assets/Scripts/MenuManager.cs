using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MenuManager : MonoBehaviour, IDataPersistence
{
    [SerializeField] private int gunCount = 0;
    public List<GameObject> weapons = new List<GameObject>();
    public Button buyButton, equipButton;
    [HideInInspector] public WeaponTypeHolder weaponTypeHolder;
    private float uiSliderValue = 0f;
    public TextMeshProUGUI weaponCostText;

    //[SerializeField] private bool itemEquippedAlready = false;

    [Header("ScoreBoard")]
    [Space(10)]
    [SerializeField] private TextMeshProUGUI scoreText;

    public TextMeshProUGUI SCORETEXT => scoreText;//encapsulation

    [Space(10)]
    //public int weaponPrice;
    //private GameManager gameManager;
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private AudioSource menuAudioSource;
    [SerializeField] private GameObject audioButton;
    [SerializeField] private RectTransform shopItemTransform;
    [SerializeField] private Sprite offSprite, onSprite;
    //public bool cameraCanFollow;
    public GameManager gameManager;
    //[SerializeField] private GameObject mainCamera;
    public bool gameCanStart = false;
    public bool isOnisOf = false;
    private void Awake()
    {
        weaponTypeHolder = FindObjectOfType<WeaponTypeHolder>();
        //gameManager = FindObjectOfType<GameManager>();
        //Time.timeScale = 0f;
    }
    private void Update()
    {
        weaponCostText.text = "x " + weapons[gunCount].gameObject.GetComponent<WeaponTypeHolder>()._weaponCost.ToString();


        if (weapons[gunCount].gameObject.GetComponent<WeaponTypeHolder>().isItemSold == true)
        {
            buyButton.interactable = false;
        }
        else if (weapons[gunCount].gameObject.GetComponent<WeaponTypeHolder>().isItemSold == false)
        {
            buyButton.interactable = true;
        }

        foreach (GameObject weapon in weapons)
        {
            var itemCheck2 = weapon.gameObject.GetComponent<WeaponTypeHolder>();
            if (itemCheck2.isItemSold == false)//eger listedeki obje satin alinmadiysa ve kusanilmadiysa kapat
            {
                weapon.gameObject.SetActive(false);
            }
            if (weapons[gunCount].gameObject.GetComponent<WeaponTypeHolder>().isItemEquipped == true)
            {
                foreach (GameObject item in weapons)
                {
                    if (item.gameObject.GetComponent<WeaponTypeHolder>().isItemEquipped == true && item.gameObject != weapons[gunCount].gameObject)//eger magazada baska bir objeyi satin alip kusandiysak mevcut kusanilan objeyi kapatip yeni kusanilan objeyi yerine koyuyor
                    {
                        item.gameObject.GetComponent<WeaponTypeHolder>().isItemEquipped = false;
                        item.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
    public void StartGame()
    {
        for (int i = 0; i <= gunCount; i++)
        {
            if (weapons[gunCount].gameObject.GetComponent<WeaponTypeHolder>().isItemEquipped == true)
            {
                menuPanel.SetActive(false);
                gameCanStart = true;
            }
        }
        //Time.timeScale = 1f;
        //cameraCanFollow = true;//KAMERA OKU TAKÝP EDEBÝLÝR
        //mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, new Vector3(0, 0, 0), 4f);
    }
    public void ThemeSongOnOff()
    {
        isOnisOf = !isOnisOf;
        if (isOnisOf == true)
        {
            menuAudioSource.GetComponent<AudioSource>().Stop();
            audioButton.GetComponent<Image>().sprite = offSprite;
        }
        if (isOnisOf == false)
        {
            menuAudioSource.GetComponent<AudioSource>().Play();
            audioButton.GetComponent<Image>().sprite = onSprite;
        }
    }
    public void NextObjectRight()
    {
        if (gunCount < 3)
        {
            //rotationTable.transform.position += new Vector3(-3f, 0, 0);
            //shopItemTransform.anchoredPosition += new Vector2(-900f, 0);
            uiSliderValue += 900;
            shopItemTransform.DOAnchorPosX(-uiSliderValue, 1f);
            gunCount++;
        }
    }
    public void NextObjectLeft()
    {
        if (gunCount > 0)
        {
            //rotationTable.transform.position += new Vector3(3f, 0, 0);
            //shopItemTransform.anchoredPosition += new Vector2(900f, 0);
            uiSliderValue -= 900;
            shopItemTransform.DOAnchorPosX(-uiSliderValue, 1f);
            gunCount--;
        }
    }
    public void EquipWeapon()
    {
        var itemCheck = weapons[gunCount].gameObject.GetComponent<WeaponTypeHolder>();
        //Debug.Log(weapons[gunCount].gameObject.GetComponent<WeaponTypeHolder>().isItemSold)
        if (itemCheck.isItemSold == true)
        {
            if (itemCheck.isItemEquipped == false)
            {
                weapons[gunCount].gameObject.SetActive(true);
                itemCheck.isItemEquipped = true;
            }
        }
    }
    public void BuyWeaponButton()
    {
        var weaponItem = weapons[gunCount].gameObject.GetComponent<WeaponTypeHolder>();
        if (weaponItem._weaponCost <= gameManager.coinAmount)
        {
            gameManager.coinAmount -= weaponItem._weaponCost;
            weaponItem.isItemSold = true;
        }
    }



    //Çalýþmýyor scriptble objeler için kayýta bak!!
    public void LoadData(GameData data)
    {
        var weaponItem = weapons[gunCount].gameObject.GetComponent<WeaponTypeHolder>();

        data.weaponSold.TryGetValue(weaponItem.id, out weaponItem.isItemSold);
        //if (weaponItem.isItemSold)
        //{
        //    //satýn alma butonunu kapat
        //}
    }

    public void SaveData(ref GameData data)
    {
        var weaponItem = weapons[gunCount].gameObject.GetComponent<WeaponTypeHolder>();
        if (data.weaponSold.ContainsKey(weaponItem.id))
        {
            data.weaponSold.Remove(weaponItem.id);
        }
        data.weaponSold.Add(weaponItem.id, weaponItem.isItemSold);

    }
}
