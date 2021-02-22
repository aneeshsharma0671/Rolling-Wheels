using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGeneration : MonoBehaviour
{
    public GameObject[] Ground_Prefab;
    public GameObject Ground_Parent;
    public List<GameObject> Tiles;
    public Transform Wheel;
    private float Anchor = 0;
    public int No_of_Tiles;

    public void Start()
    {
        for (int i = 0; i < No_of_Tiles; i++)
        {
            GenerateTile(Random.Range(0, Ground_Prefab.Length));
        }
    }

    public void Update()
    {
        if (Wheel.position.z - 100 > Anchor - (No_of_Tiles * 100))
        {
            GenerateTile(Random.Range(0, Ground_Prefab.Length));
            DestroyTile();
        }

    }

    void GenerateTile(int TileIndex)
    {
        GameObject Tile = Instantiate(Ground_Prefab[TileIndex], Ground_Parent.transform);
        Tile.transform.position = new Vector3(0,0, Anchor);
        Tiles.Add(Tile);
        Anchor += 100;
    }

    void DestroyTile()
    {
        Destroy(Tiles[0]);
        Tiles.RemoveAt(0);

    }


}
