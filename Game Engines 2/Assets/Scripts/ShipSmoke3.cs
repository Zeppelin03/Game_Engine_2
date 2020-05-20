using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSmoke3 : MonoBehaviour
{
    public GameObject Smoke2;


    private void OnTriggerEnter(Collider other)
    {
        Smoke2.SetActive(true);
    }
}
