using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float vel = 15f;
    public Transform piv;

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround( piv.transform.position, Vector3.up, vel*Time.deltaTime );
    }
}
