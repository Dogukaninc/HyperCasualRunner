using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    [SerializeField] private TextMeshProUGUI diamondText;
    [SerializeField] private TextMeshProUGUI gameStuationText;
    [SerializeField] private TextMeshProUGUI totalCollectedGemText;
    [SerializeField] private GameObject finalPanel;
    [SerializeField] private Button nextLevelButton;
    [SerializeField] private Transform startPos;

    [SerializeField] public static int coinAmount;
    public bool isGameFinished = false;
    ArrowMovement arrowRef;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != null)
        {
            Destroy(this.gameObject);
        }

        arrowRef = FindObjectOfType<ArrowMovement>();
        gameStuationText.gameObject.SetActive(false);
        finalPanel.gameObject.SetActive(false);
    }
    void Start()
    {
        coinAmount = 4;
        diamondText.text = coinAmount.ToString();
    }
    void Update()
    {
        totalCollectedGemText.text = coinAmount.ToString();

        diamondText.text = coinAmount.ToString();
        if (coinAmount < 1)
        {
            coinAmount = 0;
        }
    }
    public void GameOver()
    {
        Time.timeScale = 0f;
        gameStuationText.text = "Game Over!!!";
        finalPanel.gameObject.SetActive(true);
        nextLevelButton.interactable = false; //engele carptiysa bir sonraki seviyeye gecme butonunun etkilesimini kapat
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        isGameFinished = false;
        finalPanel.gameObject.SetActive(false);
    }
    public void GameFinish()
    {
        arrowRef.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        StartCoroutine(EndGameDelay());
    }
    IEnumerator EndGameDelay()
    {
        yield return new WaitForSeconds(2f);
        gameStuationText.text = "Win!!!";
        finalPanel.gameObject.SetActive(true);
    }

}
