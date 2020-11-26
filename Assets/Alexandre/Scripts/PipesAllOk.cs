using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesAllOk : MonoBehaviour
{

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
                Debug.Log("Nope");
                break;
            }
            if(i == pipes.Length - 1)
            {
                Debug.Log("You win");
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
