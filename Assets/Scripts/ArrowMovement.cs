using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    Rigidbody arrowRB;
    [SerializeField] private float arrowSpeed;
    void Start()
    {
        arrowRB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        arrowRB.velocity = Vector3.forward * arrowSpeed * Time.deltaTime;
    }
}
