using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderOk : MonoBehaviour
{

    public bool ok;

    void OnTriggerEnter2D()
    {
        ok = true;
    }

    void OnTriggerExit2D()
    {
        ok = false;
    }
}
