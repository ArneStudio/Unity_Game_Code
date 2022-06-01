using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ABC_HangManLogic : MonoBehaviour
{
    public Text timeField;
    private float time;
    private string[] wordsLocal = {"BEN","JOHN","DAVE","ELIA","AXEL","BEAR","BOB"};

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(wordsLocal[2]);

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeField.text = time.ToString();
    }
}
