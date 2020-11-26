using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Turn : MonoBehaviour
{

    public GameObject coll1;
    public GameObject coll2;
    public GameObject coll3;
    public GameObject coll4;
    public bool isOk;
    private Turn[] pipes;

    private void Start()
    {
        Invoke("TestIsOk", 0.1f);
        pipes = GameObject.FindObjectsOfType<Turn>();
    }

    public void TestIsOk()
    {
        if (coll1 == null || coll1.GetComponent<ColliderOk>().ok == true)
        {
            if (coll2 == null || coll2.GetComponent<ColliderOk>().ok == true)
            {
                if (coll3 == null || coll3.GetComponent<ColliderOk>().ok == true)
                {
                    if (coll4 == null || coll4.GetComponent<ColliderOk>().ok == true)
                    {
                        isOk = true;
                    }
                    else
                    {
                        isOk = false;
                    }
                }
                else
                {
                    isOk = false;
                }
            }
            else
            {
                isOk = false;
            }
        }
        else
        {
            isOk = false;
        }
    }


    private void OnMouseDown()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        if (hit.collider != null)
        {
            hit.collider.gameObject.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
        }

        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i].Invoke("TestIsOk", 0.2f);
        }
    }
}
