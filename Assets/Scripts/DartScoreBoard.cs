using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartScoreBoard : MonoBehaviour
{
    public List<GameObject> boardPiece = new List<GameObject>();
    public int[] scoreValue;
    void Start()
    {
        foreach (GameObject piece in boardPiece)
        {
            piece.gameObject.AddComponent<PieceScoreValue>();
        }
        for (int i = 0; i < 9; i++)
        {
            boardPiece[i].gameObject.GetComponent<PieceScoreValue>().scoreValue = scoreValue[i];
        }
    }
}
