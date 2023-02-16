using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI diamondText;
    [SerializeField] private TextMeshProUGUI gameOverText;
    public static int coinAmount;
    [SerializeField] private GameObject restartButton;
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
    }
}
