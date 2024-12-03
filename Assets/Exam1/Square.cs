using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side;

    private void Start()
    {
        Init();
        Resize();
       
        CalculateArea();
    }


    public override float CalculateArea()
    {
        Debug.Log($"{side} * {side}");
    }

    public override void Resize()
    {
        
        Debug.Log("Square is resized");
    }
}
