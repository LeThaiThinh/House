using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Switch : MonoBehaviour
{

    // Range Variables
    public bool changeRange = false;
    public float rangeSpeed = 15.0f;
    public float maxRange = 200.0f;

    // Intensity Variables
    public bool changeIntensity = false;
    public float intensitySpeed = 2.0f;
    public float maxIntensity = 100.0f;

    // Color variables
    public bool changeColors = false;
    public float colorSpeed = 1.0f;

    float startTime;

    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E)) this.GetComponent<Light>().range -= rangeSpeed;    
        if (Input.GetKeyDown(KeyCode.R)) this.GetComponent<Light>().range += rangeSpeed;
        if (Input.GetKeyDown(KeyCode.I)) this.GetComponent<Light>().intensity += intensitySpeed;        
        if (Input.GetKeyDown(KeyCode.O)) this.GetComponent<Light>().intensity -= intensitySpeed;
        if (Input.GetKeyDown(KeyCode.C))
        {
            this.GetComponent<Light>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
    void OnMouseUpAsButton()
    {
            this.GetComponent<Light>().enabled = !this.GetComponent<Light>().enabled;
    }
}