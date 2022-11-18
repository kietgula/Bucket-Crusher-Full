using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameEnvironment
{
    //Singleton setup
    private static GameEnvironment instance;
    public static GameEnvironment Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new GameEnvironment();
            }
            return instance;
        }
    }
    //

    // Singleton Data

    private List<GameObject> bricks = new List<GameObject>();
    public List<GameObject> Bricks { get { return bricks; } }

    public void AddBrick(GameObject brick)
    {
        bricks.Add(brick);
    }

    public void RemoveBrick(GameObject brick)
    {
        int index = bricks.IndexOf(brick);
        bricks.RemoveAt(index);
    }

}
