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
        this.Print_Lanz();
        this.Print_Nathan();
        this.Print_Richmond();
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
        Debug.Log("I am Neil Del Gallego! Wahahaha.");
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

    private void Print_Lanz()
    {
        string name = "Lanz";
        Debug.Log($"<b>Howdy!</b> This is <color=red>{name}</color>");

    }

    private void Print_Nathan()
    {
        Debug.Log("I am Nathan");
    }

    private void Print_Richmond()
    {
        Debug.Log("I Am Richmond");
    }
}
