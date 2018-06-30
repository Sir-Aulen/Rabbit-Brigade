using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour {

    public List<List<int>> map = new List<List<int>>();

    string row;

    private void Start()
    {
        newMap(5, 3);
    }

    public void newMap(int height, int length)      //0: Wall
    {                                               //1: Corridor
        map.Clear();

        for (int i = 0; i < height; i++)
        {
            map.Add(new List<int>());
            for (int ii = 0; ii < length; ii++) map[i].Add(0);
        }
        
        for (int i = 0; i < height; i++)
        {
            for (int ii = 0; ii < length; ii++) row += map[i][ii].ToString();
            Debug.Log(row);
            row = "";
        }
    }
}
