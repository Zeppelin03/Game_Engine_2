using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointScript : MonoBehaviour
{

    public GameObject Ship;
    public GameObject Beam1;
    public GameObject Beam2;
    public GameObject Smoke;

    private void OnTriggerEnter(Collider other)
    {
        Ship.GetComponent<MainShip>().enabled = false;
        Beam1.SetActive(true);
        Beam2.SetActive(true);
        Smoke.SetActive(true);

    }
}
