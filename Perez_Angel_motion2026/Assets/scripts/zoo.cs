using UnityEngine;
using System.Collections.Generic;

public class zoo : MonoBehaviour
{

    public List<string> animals;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        animals.Add("penguin");
        animals.Add("dino");
        animals.Add("shark");

        animals.Remove("dino");




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
