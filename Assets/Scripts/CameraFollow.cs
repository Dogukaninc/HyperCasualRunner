using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offSet;
    [SerializeField] private float camSpeed;
    MenuManager menuManager;
    private void Awake()
    {
        menuManager = FindObjectOfType<MenuManager>();
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offSet, camSpeed);
        /*
        if (menuManager.cameraCanFollow)
        {
        }
        */
    }
}
