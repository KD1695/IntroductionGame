using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPopup : MonoBehaviour
{
    [SerializeField] GameObject popUp;

    private void OnMouseEnter() 
    {
        popUp.SetActive(true);
    }

    private void OnMouseExit() 
    {
        popUp.SetActive(false);
    }
}
