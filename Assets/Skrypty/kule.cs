using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kule.cs : MonoBehaviour
{
	public Vector2 StartingVelocity;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2d>().velocity = StartingVelocity;
        
		Destroy(gameObject, 10);
    }

	private void OnCollisionEnter2D(Collision2d collision)
	{
		var enemy = collision.collider.GetComponent<Enemy>();
		enemy?.Die();

		Destroy(gameObject);
	}
}
