using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    enum GravityDirection { Down, Left, Up, Right };
    GravityDirection Direction;
    float GravityStrength = -1.0f;
    void Start()
    {
        Direction = GravityDirection.Down;
    }

    void FixedUpdate()
    {
        switch (Direction)
        {
            case GravityDirection.Down:
                Physics2D.gravity = new Vector2(0, GravityStrength);
                break;
            default:
                Physics2D.gravity = new Vector2(0, GravityStrength);
                break;
        }
    }
}
