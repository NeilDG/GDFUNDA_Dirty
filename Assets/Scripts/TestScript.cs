﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.PrintGarret();
        this.Print_Neil();
        this.Print_Marielle();
        this.Print_Lo();
        this.Print_Gian();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void PrintGarret()
    {
        Debug.Log("This is Garret");
    }

    private void Print_Neil()
    {
        Debug.Log("I am Neil.");
    }

    private void Print_Gian(){
        Debug.Log("Hewwo OwO I am Gian UwU");
    }
    

    private void Print_Marielle()
    {
        Debug.Log("I am Marielle.");
    }
    private void Print_Lo() 
    {
        Debug.Log("I am Jacob");
    }
}
