using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    private int _x;
    private int _y;
    bool _passable;
    public GameObject Resident { get; set; }
    

    public Tile(int x, int y, bool passable, GameObject resident) 
    {
        this._x = x;
        this._y = y;
        this._passable = passable;
        this.Resident = resident;
    }

    public int X { get { return _x; } }
    public int Y { get { return _y; } }

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
