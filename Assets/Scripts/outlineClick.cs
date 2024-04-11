using GameCreator.Runtime.Console;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutLineClick : MonoBehaviour
{
    public GameObject highlightedObject = null;


    void Update()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);


        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {

            if (hit.transform.gameObject.tag == "clickable")
            {
                

                if (highlightedObject != hit.transform.gameObject)
                {

                    if (highlightedObject != null) {
                        highlightedObject.GetComponent<Outline>().enabled = false;
                    }
                    
                    highlightedObject = hit.transform.gameObject;
                    highlightedObject.GetComponent<Outline>().enabled = true;
                    
                }
                
                
            }
            else
            {

                if (highlightedObject != null)
                {
                    highlightedObject.GetComponent<Outline>().enabled = false;
                    highlightedObject = null;
                }
            }
        }
    }
}
