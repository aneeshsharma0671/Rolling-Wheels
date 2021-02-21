using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackGeneration : MonoBehaviour
{
    public GameObject[] trackprefabs;
    public GameObject track_Parent;
    public List<GameObject> tracks;
    public Transform Wheel;
    private float Anchor = 0;
    public float number_of_tiles;

    public void Start()
    {
        for (int i = 0; i < number_of_tiles; i++)
        {
           if(i==0)
            {
                GenerateTrack(i);
            }
            else
            {
                GenerateTrack(Random.Range(1, trackprefabs.Length));
            }
              
        }
    }

    public void Update()
    {
        if (Wheel.position.z - 100 > Anchor - (number_of_tiles * 100))
        {
            GenerateTrack(Random.Range(1, trackprefabs.Length));
            DestroyTrack();
        }
        
    }

    void GenerateTrack(int TrackIndex)
    {
        GameObject Track = Instantiate(trackprefabs[TrackIndex],track_Parent.transform);
        Track.transform.position = new Vector3(0,0,Anchor);
        tracks.Add(Track);
        Anchor += 100;
    }

    void DestroyTrack()
    {
        Destroy(tracks[0]);
        tracks.RemoveAt(0);
    }
}
