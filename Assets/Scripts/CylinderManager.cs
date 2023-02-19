using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderManager : MonoBehaviour
{
    public List<GameObject> cylinderList = new List<GameObject>();
    public GameObject cylinder;
    GameManager gameManager;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        if (gameManager.isGameFinished == true)
        {
            SpawnNextLevel();
        }
    }
    public void SpawnNextLevel()
    {
        GameObject cylinderTemp = Instantiate(cylinder, transform.position, Quaternion.identity);
        cylinderTemp.transform.position = transform.position;
        cylinderList.Add(cylinderTemp);
        gameManager.isGameFinished = false;
    }
}
