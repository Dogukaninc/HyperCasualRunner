using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    void Update()
    {
        //KeyBoardMovement();
        if (Input.touchCount == 1)
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
