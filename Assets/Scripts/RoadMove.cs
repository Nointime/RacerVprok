using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour
{
    GameSetting GameSetting;

    private const float  resetPositionZ = -20f; // Позиция Z, при достижении которой дорога сбрасывается
    private const float startPositionZ = 20f;  // Начальная позиция Z

    private void Awake()
    {
        GameSetting = FindObjectOfType<GameSetting>();
    }

    void Update()
    {
        if (GameSetting.IsGame)
        {
            MoveRoad();
        }

    }

    void MoveRoad()
    {
        transform.Translate(Vector3.back * GameSetting.Speed * Time.deltaTime);

        if (transform.position.z <= resetPositionZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, startPositionZ);
        }
    }
}
