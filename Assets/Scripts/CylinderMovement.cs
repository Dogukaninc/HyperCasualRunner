using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        //KeyBoardMovement();
        if (Input.touchCount > 0)
        {
            Touch screenTouch = Input.GetTouch(0);
            if (screenTouch.phase == TouchPhase.Moved)
            {
                transform.Rotate(0f, 0f, screenTouch.deltaPosition.x * Time.deltaTime * rotationSpeed);
            }
        }
    }
    private void KeyBoardMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * horizontal);
    }
}
