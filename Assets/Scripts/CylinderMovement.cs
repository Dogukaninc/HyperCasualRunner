using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    MenuManager menuManager;
    private void Start()
    {
        menuManager = FindObjectOfType<MenuManager>();
    }
    void Update()
    {
        if (menuManager.gameCanStart)
        {
            if (Input.touchCount > 0)
            {
                Touch screenTouch = Input.GetTouch(0);
                if (screenTouch.phase == TouchPhase.Moved)
                {
                    transform.Rotate(0f, 0f, screenTouch.deltaPosition.x * Time.deltaTime * rotationSpeed);
                }
            }
        }
    }
}
