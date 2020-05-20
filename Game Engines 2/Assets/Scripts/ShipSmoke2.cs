using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSmoke2 : MonoBehaviour
{
    public GameObject Smoke3;


    private void OnTriggerEnter(Collider other)
    {
        Smoke3.SetActive(true);
    }
}
