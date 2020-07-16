using System.Collections;
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
<<<<<<< HEAD
        this.Print_Hackerman();
=======
        this.Print_Gian();
>>>>>>> 7fe0729bd0c5fcd62804658efb2dabd90685512a
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
<<<<<<< HEAD
        
=======

    private void Print_Gian(){
        Debug.Log("Hewwo OwO I am Gian UwU");
    }
    

>>>>>>> 7fe0729bd0c5fcd62804658efb2dabd90685512a
    private void Print_Marielle()
    {
        Debug.Log("I am Marielle.");
    }
    private void Print_Lo() 
    {
        Debug.Log("I am Jacob");
    }






    private void Print_Hackerman()
    {
        Debug.Log("I am JC the hacker");
    }
}