using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBoard : MonoBehaviour
{
    public GameObject brokenBoard;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            Instantiate(brokenBoard, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
