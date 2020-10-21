using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Switch : MonoBehaviour
{
   
    void OnMouseUpAsButton()
    {
            this.GetComponent<Light>().enabled = !this.GetComponent<Light>().enabled;
    }
}