using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10))
            {
                Debug.DrawLine(ray.origin, hit.point);
                Debug.Log(hit.transform.tag);
                GameObject hitObject = hit.transform.gameObject;
                if (hitObject.tag == "interactive")
                {
                    hitObject.SendMessage("Interact");
                }
            }
        }
    }
}