using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{

    private Grid grid;

    // Start is called before the first frame update
    private void Start()
    {
        this.grid = new Grid(20, 10, 1f, new Vector3(-10, -5));
    }
    
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            this.grid.SetValue(UtilsClass.GetMouseWorldPosition(), 2) ;
        }
        
        if (Input.GetMouseButtonDown(1)) {
            Debug.Log(this.grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }

    }
}
