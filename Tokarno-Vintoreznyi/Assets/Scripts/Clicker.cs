using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Clicker : MonoBehaviour, IPointerClickHandler
{
      public GameObject Object_Hits;
    public void OnPointerClick(PointerEventData eventData)
    {
        Object_Hits.gameObject.SetActive(false);
    }

}

