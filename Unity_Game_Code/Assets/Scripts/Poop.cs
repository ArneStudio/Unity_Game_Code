using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour
{
    public GameObject poop;
    public Transform poopTwist;
    public Transform bum;

    public void AddObject()
    {
        Instantiate(poop, bum.position, poopTwist.rotation);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
