using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelector : MonoBehaviour
{

    //public GameObject tower;

    public int[] availableTowers;

    public int selectedTower = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit click;
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(mouseRay, out click))
            {
                Placeable p = click.collider.GetComponent<Placeable>();

                if (p.isOccupied == false)
                {
                    SpawnTower(availableTowers[selectedTower], p.transform.position);
                }

            }
        }
    }

    public void SpawnTower(int towerNumber, Vector3 position)
    {
        GameObject towerPrefab = Resources.Load<GameObject>("Prefabs/Towers/Tower " + towerNumber);
        Instantiate(towerPrefab, position, Quaternion.identity);
    }
}
