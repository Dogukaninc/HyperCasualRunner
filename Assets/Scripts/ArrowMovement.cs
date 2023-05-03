using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    Rigidbody arrowRB;
    [SerializeField] private float arrowSpeed;
    GameManager gameManager;
    MenuManager menuManager;

    [Header("Score")]
    [Space(10)]
    public int totalScore;


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
        if (other.gameObject.CompareTag("DartPiece"))
        {
            //Total score tahta parcasina carpinca arttir
            totalScore += other.gameObject.GetComponent<PieceScoreValue>().scoreValue;
            Debug.Log(totalScore);
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
