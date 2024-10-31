using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBuilding : MonoBehaviour
{
    
    [SerializeField] private Transform[] Points;
    [SerializeField] private Transform Place;
    [SerializeField] private GameObject[] BuildingPrefA;
    [SerializeField] private GameObject[] BuildingPrefB;
    [SerializeField] private float spawnTime;

    float cTime = 0;

    GameSetting GameSetting;

    void Start()
    {
        GameSetting = FindObjectOfType<GameSetting>();
    }

    void Update()
    {
        if (GameSetting.IsGame)
        {
            CreateBuilding();
        }

    }

    void CreateBuilding()
    {
        cTime += Time.deltaTime;

        if (cTime >= spawnTime)
        {
            Instantiate(BuildingPrefA[Random.Range(0, 3)], Points[0].position,Quaternion.identity,Place);
            Instantiate(BuildingPrefB[Random.Range(0, 3)], Points[1].position,Quaternion.identity,Place);

            cTime = 0f;
        }
    }
}
