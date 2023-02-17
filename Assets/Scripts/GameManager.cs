using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI diamondText;
    [SerializeField] private TextMeshProUGUI gameStuationText;
    [SerializeField] private GameObject restartButton;
    public static int coinAmount;
    private void Awake()
    {
        gameStuationText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }
    void Start()
    {
        coinAmount = 0;
        diamondText.text = coinAmount.ToString();
    }
    void Update()
    {
        diamondText.text = coinAmount.ToString();
    }
    public void GameOver()
    {
        Time.timeScale = 0f;
        gameStuationText.gameObject.SetActive(true);
        gameStuationText.text = "Game Over!!!";
        restartButton.gameObject.SetActive(true);
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void GameFinish()
    {
        gameStuationText.gameObject.SetActive(true);
        gameStuationText.text = "Win!!!";
        Time.timeScale = 0f;
    }
}
