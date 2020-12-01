using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderOk : MonoBehaviour
{

    public bool ok;

    void OnTriggerStay2D(Collider2D col)
    {
        ok = true;
        col.gameObject.GetComponentInParent<Turn>().Invoke("TestIsOk", 0.1f);
    }

    void OnTriggerExit2D()
    {
        ok = false;
    }
}
