using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerManager : MonoBehaviour
{
    public List<GameObject> rollers = new List<GameObject>();
    public List<GameObject> totalRollers = new List<GameObject>();
    public int index = 0;
    public Transform startPos;
    public GameObject scoreBoard;
    ArrowMovement arrowMovement;
    private void Awake()
    {
        GameObject temp = Instantiate(rollers[index], transform.position, Quaternion.identity);
        totalRollers.Add(temp);
    }
    private void Start()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        pooledRollers = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
=======
=======
>>>>>>> parent of 49c8089 (objectPooling)
        arrowMovement = FindObjectOfType<ArrowMovement>();
    }
    public void LoadNextLevel()
    {
        GameObject rollerTemp = Instantiate(rollers[index + 1], transform.position, Quaternion.identity);
        index++;
        totalRollers.Add(rollerTemp);
<<<<<<< HEAD
        if (totalRollers.Count > 1)//listeden �nceki seviyeyi siliyor
>>>>>>> parent of 1603c22 (homework)
=======


        if (index > 3) return;///ODEV ICIN

        if (totalRollers.Count > 1)//listeden �nceki seviyeyi siliyor
>>>>>>> parent of 49c8089 (objectPooling)
        {
            Destroy(totalRollers[totalRollers.Count - 2]);
        }
        arrowMovement.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        scoreBoard.SetActive(false);
        arrowMovement.GetComponent<Transform>().transform.position = startPos.position;
    }
}
