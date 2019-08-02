using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left") || Input.GetKey(KeyCode.A))
        {
            _rigidbody2D.AddForce(new Vector2(-5, 0));
        }

        if (Input.GetKey("right") || Input.GetKey(KeyCode.D))
        {
            _rigidbody2D.AddForce(new Vector2(5, 0));
        }
    }
}
