using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EditorUtilityDisplayPopupMenu : MonoBehaviour
{
    public GameObject Panel;
    //public GameObject panel;
    bool isActive;


    void Start()
    {

    }

    void Update()
    {
        isActive = true;
        if (isActive)
        {
            if (Input.GetMouseButton(1))
            {
                Panel.SetActive(true);
                Panel.gameObject.transform.position = Input.mousePosition;
                
             
            }
            isActive = false;
        }
        if (isActive == false && Input.GetMouseButton(0))
        {
            Panel.SetActive(false);
        }

    }
}
