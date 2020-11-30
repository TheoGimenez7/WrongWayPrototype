using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class ItemSlot : MonoBehaviour, IDropHandler {
    [SerializeField]
    private string TheSearchedPiece = "";

    public GameObject manager;

    public static int nombrePièceOk = 0;

    public void OnDrop (PointerEventData eventData) {
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = GetComponent<RectTransform> ().anchoredPosition;

            if (eventData.pointerDrag.gameObject.name == TheSearchedPiece) {
                nombrePièceOk += 1;
                if (nombrePièceOk == 4) {
                    if (GlobalCountDown.TimeLeft >= TimeSpan.Zero)
                    {
                        GameManager.levelsCleared += 1;
                        manager.GetComponent<GameManager>().LoadLevel("GameOver");
                    }
                    else
                    {
                        manager.GetComponent<GameManager>().LoadLevel("GameOver");
                    }
                }
            }
        }
    }

}