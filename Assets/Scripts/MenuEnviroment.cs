using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEnviroment : MonoBehaviour
{
    public GameObject clouds;
    public GameObject bushAndBuildings;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCloud", 0f, 60f);
        InvokeRepeating("SpawnBushAndBuilding", 0f, 11f);
    }


    private void SpawnCloud()
    {
        GameObject newClouds = Instantiate(clouds);
        newClouds.transform.position = new Vector3(0f, 0f, -120f);
    }

    void SpawnBushAndBuilding()
    {
        GameObject newBushAndBuilding = Instantiate(bushAndBuildings);
        newBushAndBuilding.transform.position = new Vector3(0f, 0f, -130f);
    }
}
