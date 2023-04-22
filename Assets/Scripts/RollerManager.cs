using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerManager : MonoBehaviour
{

    public static RollerManager rmanagerInstance;
    public List<GameObject> pooledRollers;
    public GameObject objectToPool;
    public int amountToPool;

    void Awake()
    {
        rmanagerInstance = this;
    }

    void Start()
    {
<<<<<<< HEAD
        pooledRollers = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
=======
        arrowMovement = FindObjectOfType<ArrowMovement>();
    }
    public void LoadNextLevel()
    {
        GameObject rollerTemp = Instantiate(rollers[index + 1], transform.position, Quaternion.identity);
        index++;
        totalRollers.Add(rollerTemp);
        if (totalRollers.Count > 1)//listeden önceki seviyeyi siliyor
>>>>>>> parent of 1603c22 (homework)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooledRollers.Add(tmp);
        }
    }
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledRollers[i].activeInHierarchy)
            {
                return pooledRollers[i];
            }
        }
        return null;
    }
    
}
