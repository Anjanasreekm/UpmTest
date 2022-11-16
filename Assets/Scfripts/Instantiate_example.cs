using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_example : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
          //Instantiate(prefab, Input.mousePosition, Quaternion.identity);
        
    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Debug.Log("M POS = " + mousePos);
        if (Input.GetMouseButton(1))
        {
            GameObject gameObject = Instantiate(prefab, mousePos, Quaternion.identity);
            Debug.Log("gameObject pos=  " + gameObject.transform.position);
        }
    }
}
