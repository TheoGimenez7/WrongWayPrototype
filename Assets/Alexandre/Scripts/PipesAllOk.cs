using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesAllOk : MonoBehaviour
{
    public GameObject manager;

    private Turn[] pipes;


    void Start()
    {
        pipes = GameObject.FindObjectsOfType<Turn>();
        
    }

    void test()
    {
        for(int i = 0; i<pipes.Length; i++)
        {
            pipes[i].TestIsOk();
            if (pipes[i].isOk != true)
            {
                GameManager.levelsCleared = 0;
                manager.GetComponent<GameManager>().LoadLevel("PuzzleScene");
                break;
            }
            if(i == pipes.Length - 1)
            {
                GameManager.levelsCleared += 1;
                manager.GetComponent<GameManager>().LoadLevel("GameScene_DragDrop");
                break;
            }
        }
    }

    private void OnMouseDown()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        if (hit.collider != null)
        {
            this.test();
        }
    }
}
