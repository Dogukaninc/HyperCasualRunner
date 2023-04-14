using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableDiamond : MonoBehaviour
{
    //[SerializeField] private float rotationSpeed;

    [SerializeField] private GameObject particlePrefab;
    void Update()
    {
        //transform.localRotation = Quaternion.Euler(Vector3.right * rotationSpeed * Time.deltaTime);

        //elmaslar kendi ekseni etrafinda donecek
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            GameManager.coinAmount++;
            AudioManager.instance.Play("Diamond");
            Instantiate(particlePrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
