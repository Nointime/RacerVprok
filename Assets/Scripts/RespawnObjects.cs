using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnObjects : MonoBehaviour
{
    [SerializeField] private Transform[] Points;
    [SerializeField] private Transform Place;
    [SerializeField] private GameObject[] obj;
    private float spawnTime;

    private float cTime = 0;

    GameSetting GameSetting;

    void Start()
    {
        GameSetting = FindObjectOfType<GameSetting>();
        spawnTime = Random.Range(0.6f, 1f);
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
            int index = Random.Range(0, obj.Length);
            Instantiate(obj[index], Points[Random.Range(0, Points.Length)].position, Quaternion.identity, Place);

            cTime = 0f;
            spawnTime = Random.Range(0.6f, 1f);
        }
    }
}
