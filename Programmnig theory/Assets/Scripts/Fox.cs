using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : Enemy // INHERITANCE
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // POLYMORPHISM
    public override void Move()
    {
        speed = 2;
        base.Move(); // ABSTRACTION
    }
}
