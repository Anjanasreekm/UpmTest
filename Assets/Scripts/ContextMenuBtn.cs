using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextMenuBtn : MonoBehaviour
{
    public GameObject Panel;
    bool isActive;
    void Start()
    {
        
    }

    // Update is called once per frame
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
