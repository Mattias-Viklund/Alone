using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TData : MonoBehaviour
{
    private Terrain t;
    private TerrainData tData;
    private TerrainCollider tCollider;

    // Start is called before the first frame update
    void Start()
    {
        t = (Terrain)gameObject.AddComponent(typeof(Terrain));
        tCollider = (TerrainCollider)gameObject.AddComponent(typeof(TerrainCollider));

        tData = new TerrainData();
        tData.heightmapResolution = 8;

        t.terrainData = tData;
        tCollider.terrainData = tData;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                float[,] arr = new float[2, 2];
                arr[0, 0] = 1;
                arr[0, 1] = 1;
                arr[1, 0] = 1;
                arr[1, 1] = 1;

                tData.SetHeights((int)hit.point.x, (int)hit.point.z, arr);

            }
        }
    }
}
