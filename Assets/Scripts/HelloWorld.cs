using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class HelloWorld : MonoBehaviour
{
    //intergers
    
    byte levelNo = 255;
    sbyte withPositive = 127;
    short smallNo = 32_000;
    ushort smallNoNoNegative = 64_000;
    public int speed = 10;
    uint speed2 = 25;
    long bigNumber = 1_000_000_000_000_000;
    //decimals
    float kesilirSayý = 10.5f;
    double doubleDecimal = 10.7;
    decimal decNo = 22.5m;
    //characters
    string myText = "Hello World 2!!";
    char smiley = 's';
    //Unity ozel
    public GameObject helloText;







    // Start is called before the first frame update
    void Start()
    {
        //console mesaji
        print(myText);
        // oyuun fpsini sabitleme
        Application.targetFrameRate = 30; 
        helloText.GetComponent<TextMeshPro>().text = bigNumber.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello Again!");
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
