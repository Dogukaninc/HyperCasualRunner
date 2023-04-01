using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    Rigidbody arrowRB;
    [SerializeField] private float arrowSpeed;
    GameManager gameManager;
    MenuManager menuManager;
    void Start()
    {
        menuManager = FindObjectOfType<MenuManager>();
        gameManager = FindObjectOfType<GameManager>();
        arrowRB = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (menuManager.gameCanStart)
        {
            arrowRB.velocity = Vector3.forward * arrowSpeed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FinishLine"))
        {
            gameManager.GameFinish();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CirclePart"))
        {
            gameManager.GameOver();
        }
        if (collision.gameObject.CompareTag("Part"))
        {
            collision.gameObject.GetComponent<Collider>().isTrigger = true;
        }
    }
}
