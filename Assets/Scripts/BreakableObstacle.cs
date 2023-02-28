using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObstacle : MonoBehaviour
{
    [SerializeField] private GameObject breakableObsPrefab;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            Instantiate(breakableObsPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
