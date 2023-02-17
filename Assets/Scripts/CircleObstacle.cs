using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleObstacle : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
