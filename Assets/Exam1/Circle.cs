using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
   private float radius;
    private void Start()
    {
        Init();
        Resize();
        
        CalculateArea();
    }

    public override float CalculateArea()
    {
        Debug.Log($"");
    }

    public override void Resize()
    {
        
        Debug.Log("Circle is resized");
    }
}
