using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public class Testing1 : MonoBehaviour
{
    private Grid1 grid;

    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid1(5, 5, 10f, new Vector3(20,0));  
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }

}
