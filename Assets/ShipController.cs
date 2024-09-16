using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Object cubePreb = Resources.Load("Container/Port-container_blue", typeof(GameObject));
        GameObject cube = Instantiate(cubePreb) as GameObject;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
