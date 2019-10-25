using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGrid 
{
    public int Length { get; }
    public int Width { get; }
    private Tile[,] _grid;

    public TileGrid(int length, int width)
    {
        this.Length = length;
        this.Width = width;
        _grid = new Tile[length, width];

        for(int x = 0; x < width; x++) 
        {
            for(int y = 0; y < length; y++) 
            {
                _grid[x,y] = new Tile(x, y, true, null);
            }
        }
    }

    public Tile GetTileAt(int x, int y)
    {
        return _grid[x,y];
    }

    public GameObject GetGameObjectAt(int x, int y)
    {
        return _grid[x,y].Resident;
    }

    public void SetGameObjectAt(GameObject gameObject, int x, int y)
    {
        _grid[x,y].Resident = gameObject;
    }

    public Unit GetUnitAt(int x, int y)
    {
        return _grid[x,y].ResidentUnit;
    }

    
}
