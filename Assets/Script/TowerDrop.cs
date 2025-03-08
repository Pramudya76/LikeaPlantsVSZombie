using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TowerDrop : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject Prefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            PlaceObject();
        }
    }

    private void PlaceObject() {
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = 0f;

        Vector3Int cellPosition = tilemap.WorldToCell(mouseWorld);

        Vector3 cellCenterPosition = tilemap.GetCellCenterWorld(cellPosition);

        Instantiate(Prefabs, cellCenterPosition, Quaternion.identity);

    }

}
