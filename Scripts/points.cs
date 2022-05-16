using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public static points instance;
    public Text point;
    public int spoint;

    private void Awake()
    {
        instance=this;
    }
    void Start()
    {
        load();
        point.text=spoint.ToString();
    }
    public void load()
    {
        savedata data = pointsdata.loaddata();
        spoint = data.spoint;
    }
    public void AddPoint()
    {
        spoint+=100;
        pointsdata.savepoint(this);
        point.text=spoint.ToString();
    }
    public void AddPoint5()
    {
        spoint+=5;
        pointsdata.savepoint(this);
    }
    public void SubPoint5()
    {
        spoint-=10;
        pointsdata.savepoint(this);
    }
    public void drawPoint5()
    {
        spoint-=5;
        pointsdata.savepoint(this);
    }
}
