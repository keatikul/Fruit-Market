using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Rigidbody2D rb;
    private float speed = 400;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(20 * Time.deltaTime * speed,20 * Time.deltaTime * speed));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
