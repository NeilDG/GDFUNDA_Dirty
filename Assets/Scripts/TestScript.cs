using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.Print_Neil();
        this.Print_Hackerman();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Print_Neil()
    {
        Debug.Log("I am Neil.");
    }

    private void Print_Hackerman()
    {
        Debug.Log("I am JC the hacker");
    }
}
