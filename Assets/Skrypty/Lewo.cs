﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lewo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.A)) { //obraca sie jezeli A
        transform.rotation = Quaternion.Euler(transform.rotation.x, 180, transform.rotation.z);
     }else if(Input.GetKeyDown(KeyCode.D)) { // obraca sie jezeli D
       transform.rotation = Quaternion.Euler(transform.rotation.x, 0, transform.rotation.z);
    }
    }
}
