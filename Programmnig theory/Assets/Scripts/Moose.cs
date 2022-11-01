using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moose : Enemy // INHERITANCE
{
    void Update()
    {
        Move();
    }

    // POLYMORPHISM
    public override void Move()
    {
        speed = 0.2f;
        base.Move(); // ABSTRACTION
    }
}
