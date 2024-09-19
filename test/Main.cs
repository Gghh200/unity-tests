using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using System;
using UnityEngine;
public class Main : MonoBehaviour
{
    public void Update(){
        var Current = GameObject.Find("Current");
        if (Input.GetMouseButtonDown(0) && Current != null){
            var MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            double x = Math.Truncate(MousePos.x + 0.5);
            double y = Math.Truncate(MousePos.y + 0.5);
            Debug.Log(x + " " + y);
        }
    }
}