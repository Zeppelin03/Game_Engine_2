using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainShip : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {

    }

    private void Update()
    {
        var pos = transform.position;
        pos.z += 0.1f;
        transform.position = pos;
    }
}
