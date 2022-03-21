using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : DeployableComponent
{
    public GameObject unit;
    public int damage;
    public int speed;
    public List<Coord> path = new List<Coord>();

    void FixedUpdate()
    {
        throw new System.NotImplementedException();
    }

    public void Move()
    {
        throw new System.NotImplementedException();
    }

    public void MoveTo()
    {
        throw new System.NotImplementedException();
    }

    public void FindPath()
    {
        throw new System.NotImplementedException();
    }

    public void MarkPath()
    {
        throw new System.NotImplementedException();
    }

    public void Attack(Components c)
    {
        throw new System.NotImplementedException();
    }

    public void Target(Components c)
    {
        throw new System.NotImplementedException();
    }

    public bool CheckIfPathAvailable()
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
