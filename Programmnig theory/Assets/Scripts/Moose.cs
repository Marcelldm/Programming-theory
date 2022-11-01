using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moose : Enemy
{
    // Start is called before the first frame update
    void Update()
    {
        Move();
    }

    public override void Move()
    {
        speed = 0.2f;
        base.Move();
    }
}
