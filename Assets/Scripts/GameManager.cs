using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI diamondText;
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private GameObject restartButton;
    public static int coinAmount;
    private void Awake()
    {
        gameOverText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }
    void Start()
    {
        diamondText.text = coinAmount.ToString();
    }
    void Update()
    {
        diamondText.text = coinAmount.ToString();
    }
    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverText.gameObject.SetActive(true);
        gameOverText.text = "Game Over!!!";
        restartButton.gameObject.SetActive(true);
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
