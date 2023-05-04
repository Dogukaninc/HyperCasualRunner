using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObstacle : MonoBehaviour
{
    [SerializeField] private GameObject breakableObsPrefab;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WeaponModel"))
        {
            Instantiate(breakableObsPrefab, transform.position, Quaternion.identity);

            AudioManager.instance.Play("BreakableObs");
            //FindObjectOfType<AudioManager>().Play("BreakableObs");
            Destroy(this.gameObject);
        }
    }
}
