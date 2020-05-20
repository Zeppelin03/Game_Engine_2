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
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Drone");
        Ship.GetComponent<Boid>().enabled = false;
        //Drone.GetComponent<MainShip>().enabled = false;
        Beam1.SetActive(true);
        Beam2.SetActive(true);
        Smoke.SetActive(true);
        foreach (GameObject go in gameObjectArray)
        {

            go.GetComponent<MainShip>().enabled = false;


        }

    }
}
