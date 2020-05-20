using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSmokeScript : MonoBehaviour
{
    public GameObject Smoke1;


    private void OnTriggerEnter(Collider other)
    {
        Smoke1.SetActive(true);
    }
}
