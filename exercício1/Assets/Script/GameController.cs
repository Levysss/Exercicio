using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    private Text contClick;
    private int cont=0;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Contador();
        }
    }
    void Contador()
    {
        cont+=1;
        contClick = GameObject.Find("Contador").GetComponent<Text>();
        contClick.text = cont.ToString();
    }
}
