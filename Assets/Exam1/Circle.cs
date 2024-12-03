using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
   private float radius = 2f;
    private float PI = 3.14f;
    private void Start()
    {
        Init();
        Resize();
        
        CalculateArea();
    }

    public override float CalculateArea()
    {
        Debug.Log($"Circlearea: {PI} * {radius} * {radius}");
    }

    public override void Resize()
    {
        
        Debug.Log("Circle is resized");
        Debug.Log($"Circle resized :{radius}");
    }
}
