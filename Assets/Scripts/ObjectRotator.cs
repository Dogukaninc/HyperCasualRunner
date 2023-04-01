using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private float ObjectRotationSpeed;
    [SerializeField] private ObjectRotationSO objectRotationSO;
    private bool rotatingX, rotatingY, rotatingZ;
    private void Start()
    {
        rotatingX = objectRotationSO.rotatingX;
        rotatingY = objectRotationSO.rotatingY;
        rotatingZ = objectRotationSO.rotatingZ;
    }
    void Update()
    {
        if (rotatingX == true)
        {
            transform.Rotate(ObjectRotationSpeed * Time.deltaTime, 0, 0);
        }
        if (rotatingY == true)
        {
            transform.Rotate(0, ObjectRotationSpeed * Time.deltaTime, 0);
        }
        if (rotatingZ == true)
        {
            transform.Rotate(0, 0, ObjectRotationSpeed * Time.deltaTime);
        }
    }
}
