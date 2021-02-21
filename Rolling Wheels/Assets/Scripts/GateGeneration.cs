using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateGeneration : MonoBehaviour
{

    public GameObject gate_prefab;
    public int no_of_gates;
    public GameObject gate_parent;
    public Transform Wheel;
    public List<GameObject> gates;
    private float anchor=-50;
    

    public void Start()
    {
        for (int i = 0; i < no_of_gates; i++)
        {
            GenerateGate();
        }
    }

    public void Update()
    {
        if(Wheel.position.z - 150 > anchor - (no_of_gates*200))
        {
            GenerateGate();
            DestroyGate();
        }
    }
    void GenerateGate()
    {
        GameObject Gate = Instantiate(gate_prefab,gate_parent.transform);
        Gate.transform.position = new Vector3(0, 0, anchor);
        gates.Add(Gate);
        anchor += 200;
    }

    void DestroyGate()
    {
        Destroy(gates[0]);
        gates.RemoveAt(0);
    }

    
}
