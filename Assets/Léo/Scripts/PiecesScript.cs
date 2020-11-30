using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using System;

public class PiecesScript : MonoBehaviour
{
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    public static int nbrPieces = 0;
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(UnityEngine.Random.Range(3f, 8f), UnityEngine.Random.Range(3f, -3f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position,RightPosition)<0.5f)
        {
            if (!Selected)
            {
                if (InRightPosition == false)
                {
                    transform.position = RightPosition;
                    InRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    nbrPieces += 1;
                }
            }
        }
        if (nbrPieces == 9)
        {
            if (GlobalCountDown.TimeLeft >= TimeSpan.Zero)
            {
                GameManager.levelsCleared += 1;
                nbrPieces = 0;
                manager.GetComponent<GameManager>().LoadLevel("FixThePipes");
            }
            else
            {
                nbrPieces = 0;
                manager.GetComponent<GameManager>().LoadLevel("GameOver");
            }

        }

    }
}
