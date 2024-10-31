using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    GameSetting GameSetting;

    void Start()
    {
        GameSetting = FindObjectOfType<GameSetting>();
    }

    void Update()
    {
        if (GameSetting.IsGame)
        {
            Move();
        }
    }

    void Move()
    {
        transform.Translate(Vector3.back * GameSetting.Speed * Time.deltaTime);

        if (transform.position.z < 10) Destroy(gameObject, 1);
    }
}
