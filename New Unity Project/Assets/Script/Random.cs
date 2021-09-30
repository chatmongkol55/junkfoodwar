using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Random : MonoBehaviour
{
    public GameObject TextBox;
    public int Number;
    public int NumberTwo;
    public void RandomNum()
    {
        Number = UnityEngine.Random.Range(1, 1000000);
        NumberTwo = UnityEngine.Random.Range(1, 10);
        TextBox.GetComponent<Text>().text = "" + Number+","+NumberTwo;
    }

    
}
