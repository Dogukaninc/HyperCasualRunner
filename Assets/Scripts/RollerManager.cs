using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> rollers = new List<GameObject>();
    //[SerializeField] private GameObject[] rollerPrefab;
    GameManager gameManager;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        if (gameManager.levelIndex == 1)//OYUN B�T�NCE SONRAK� LEVEL BUTONUNA BASINCA YEN� ROLL Y�KLENECEK
        {
            Instantiate(rollers[0], transform.position, Quaternion.identity);
            gameManager.levelIndex = 2;
        }
    }
}
