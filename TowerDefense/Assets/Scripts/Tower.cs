using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : Structure
{
    public int range;
    public int damage;
    public int rateOfFire;
    public Components target;

    public void Target(Components c)
    {
        throw new System.NotImplementedException();
    }

    public void Attack(Components c)
    {
        throw new System.NotImplementedException();
    }

    public bool IsUnitInRange()
    {
        throw new System.NotImplementedException();
    }

    public override bool IsDestroyed()
    {
        throw new System.NotImplementedException();
    }

    public override bool IsRigid()
    {
        throw new System.NotImplementedException();
    }
}
