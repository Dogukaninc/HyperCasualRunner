using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    void Update()
    {
        KeyBoardMovement();
    }
    private void KeyBoardMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * horizontal);
    }
}
