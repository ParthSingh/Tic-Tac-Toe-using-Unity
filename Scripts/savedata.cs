using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class savedata
{
    public int spoint;
    
    public savedata(points points)
    {
        spoint=points.spoint;
    }
}
