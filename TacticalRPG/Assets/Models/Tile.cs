using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    public int X { get; }
    public int Y { get; }
    private bool _passable;
    public GameObject Resident { get; set; }
    

    public Tile(int x, int y, bool passable, GameObject resident) 
    {
        this.X = x;
        this.Y = y;
        this._passable = passable;
        this.Resident = resident;
    }

    public bool IsPassable { get { return (_passable && Resident != null); } }

    public Unit ResidentUnit
    {
        get 
        {
            if(Resident != null) 
            {
                Unit unit = Resident.GetComponent<Unit>();
                if(unit != null) return unit;
            }
            return null;
        }
    }  
}