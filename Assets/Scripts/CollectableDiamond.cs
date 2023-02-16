using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableDiamond : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            GameManager.coinAmount++;
            Destroy(this.gameObject);
        }
    }
}
