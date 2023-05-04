using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBoard : MonoBehaviour
{
    public GameObject brokenBoard;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WeaponModel"))
        {
            Instantiate(brokenBoard, transform.position, Quaternion.identity);
            AudioManager.instance.Play("BreakableObs");
            Destroy(this.gameObject);
        }
    }
}
