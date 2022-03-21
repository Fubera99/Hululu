using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpecialMovementUnit : Unit
{
    public bool reducedSpeed;

    public abstract bool IsMovingThroughObstacle();

    public void SetSpeed(int speed)
    {
        this.speed = speed;
    }
}
