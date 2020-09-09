using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Vector3 rotation;

    void Start()
    {
        rotation = new Vector3(15, 30, 45);
    }

    void Update()
    {
        this.transform.Rotate(rotation * Time.deltaTime);
        
    }
}
