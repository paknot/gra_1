using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strzelanie : MonoBehaviour
{
	public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
	if (Input.GetButtonDown(Fire1))
		{
			var projectile = GameObject.Instantiate(projectilePrefab, transform.position, projectilePrefab.rotation);
		}
        
    }
}
