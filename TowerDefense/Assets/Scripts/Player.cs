using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int gold;
    public List<Unit> unitsToBuild = new List<Unit>();
    public List<Tower> towersToBuild = new List<Tower>();
    public List<string> researchedComponents = new List<string>();
    public string researchingName;
    public int researchingRemainingRounds;

    public void researchComponent(Components c)
    {
        throw new System.NotImplementedException();
    }
}
