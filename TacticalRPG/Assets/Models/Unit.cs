using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit
{
    public UnitJob Job { get; set; }

    public Unit(UnitJob job)
    {
        this.Job = job;
    }
}
