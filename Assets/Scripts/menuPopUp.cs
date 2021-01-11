using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPopUp : MonoBehaviour
{
    
    public GameObject Panel;
    [SerializeField] private string selectableTag = "Selectable";


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                
                if (selection.CompareTag(selectableTag)) {
                    //var selectionRenderer = selection.GetComponent<Renderer>();
                    //if (selectionRenderer)
                    //{
                        if (Panel != null)
                        {
                            bool isActive = Panel.activeSelf;
                            Panel.SetActive(!isActive);
                        }
                    //}
                }
               
                
                //if (hit.transform != null)
                //{
                //    GameObject item;
                //    if(item= hit.transform.GetComponent<GameObject>()) { 

                //    if (Panel != null)
                //    {
                //        bool isActive = Panel.activeSelf;
                //        Panel.SetActive(!isActive);
                //    }
                //    }
                //}
            }

        }
    }
}
