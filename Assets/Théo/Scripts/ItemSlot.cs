using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler {
    [SerializeField]
    private string TheSearchedPiece = "";

    public static int nombrePièceOk = 0;

    public void OnDrop (PointerEventData eventData) {
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = GetComponent<RectTransform> ().anchoredPosition;

            if (eventData.pointerDrag.gameObject.name == TheSearchedPiece) {
                nombrePièceOk += 1;
                if (nombrePièceOk == 4) {
                    Debug.Log ("Changement de scène");
                }
            }
        }
    }

}