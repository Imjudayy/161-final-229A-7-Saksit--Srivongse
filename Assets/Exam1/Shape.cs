using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;

    private void Start()
    {
        Draw();
        Resize();
    }

    public void Init(string shapeName, string shapName2)
    {
          = shapeName
    }

    public abstract float CalculateArea();

    public virtual void Resize()
    {
        Debug.Log("Resizing Shape....");
    }

    public void Draw()
    {
      Debug.Log("Drawing");
    }

}
