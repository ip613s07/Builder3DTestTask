using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickController : MonoBehaviour
{

    [SerializeField]    
    private UIController _uiController;    

    // Update is called once per frame
    void Update()
    {

        if (!EventSystem.current.IsPointerOverGameObject() && Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {

                if (hit.transform.gameObject.tag == "Tile")
                {

                    _uiController.OpenBuildingWindow(hit.transform.gameObject);                    

                }

                if (hit.transform.gameObject.tag == "Building")
                {

                    _uiController.OpenUpgradeWindow(hit.transform.gameObject);

                }

            }

        }

    }    

}
