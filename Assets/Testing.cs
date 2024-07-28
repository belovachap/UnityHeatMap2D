using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{

    [SerializeField] private HeatMapVisual heatMapVisual;
    private Grid grid;

    // Start is called before the first frame update
    private void Start()
    {
        this.grid = new Grid(20, 10, 1f, new Vector3(-10, -5));
        heatMapVisual.SetGrid(grid);
    }
    
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 position = UtilsClass.GetMouseWorldPosition();
            int value = this.grid.GetValue(position);
            this.grid.SetValue(position, value + 5);
        }
        
        if (Input.GetMouseButtonDown(1)) {
            Debug.Log(this.grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }

    }
}
