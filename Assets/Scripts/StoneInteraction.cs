using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneInteraction : MonoBehaviour
{
    public virtual void Interact() 
    {
        Destroy(this.gameObject);
    }
}
