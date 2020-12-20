using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public float moveSpeed = 5f; // predkosc
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Jump();
    Vector3 poruszanie = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f); //ruch koryzontalny
    transform.position += poruszanie * Time.deltaTime * moveSpeed;
    }
    void Jump(){   //skok
        if (Input.GetButtonDown("Jump") ){
        //sila skoku                                                    |
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,6f), ForceMode2D.Impulse);
    }
    }
}
