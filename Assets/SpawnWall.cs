using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    [SerializeField] GameObject brickPrefab;
    [SerializeField] int wallHeight;
    [SerializeField] int wallWidth;
    [SerializeField] Vector3 basePos;

    // Update is called once per frame
    void Start()
    {
        for (int i = 0; i < wallHeight; i++)
            for (int j = 0; j < wallWidth; j++)
            {
                GameObject brick = Instantiate(brickPrefab, basePos + new Vector3(j * 0.2f, i * 0.2f, 0), Quaternion.identity);
                GameEnvironment.Singleton.AddBrick(brick);
            }
    }
}
