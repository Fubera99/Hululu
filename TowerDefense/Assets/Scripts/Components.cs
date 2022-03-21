using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Components : MonoBehaviour
{
    public string Type;
    public int PosX;
    public int PosY;
    public int SizeX;
    public int SizeY;

    public abstract bool IsRigid();
}
