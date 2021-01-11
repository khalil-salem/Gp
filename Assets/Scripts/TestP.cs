using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestP : MonoBehaviour
{
    Text itemNamePanel;
    public Item item;
    public GameObject Panel;
    [SerializeField] private string selectTag = "Select";
    void Start() {
        itemNamePanel = Panel.GetComponent<Text>();
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                var selectionRenderer = selection.GetComponent<Renderer>();
                
                if (selectionRenderer!=null)
               {
                    
                   // if (selection.CompareTag(selectTag)) {
                        if (Panel != null)
                        {
                            bool isActive = Panel.activeSelf;
                        Debug.Log(isActive);
                            Panel.SetActive(!isActive);
                           Debug.Log(item.price);
                        }
                    //}
                    

                }



            }

        }
    }
    //void UnityApiMouseEvents()
    //{
    //    RaycastHit hit;
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    if (Physics.Raycast(ray, out hit))
    //    {
    //        if (hit.rigidbody != null)
    //            hit.rigidbody.gameObject.SendMessage("OnMouseDown");
    //        else
    //            hit.collider.SendMessage("OnMouseDown");
    //    }

    //}
}
