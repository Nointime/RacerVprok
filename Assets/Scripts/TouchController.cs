using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    PlayerController PlayerController;
    float x = 0;
    GameSetting GameSetting;

    private void Awake()
    {
        PlayerController = FindObjectOfType<PlayerController>();
    }

    void Start()
    {
        GameSetting = FindObjectOfType<GameSetting>();
    }

    void Update()
    {

        if (GameSetting.IsGame)
        {

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.position.x > Screen.width / 2) x = 1;
                else if (touch.position.x < Screen.width / 2) x = -1;
            }
            else
            {
                x = 0;
            }

            PlayerController.MoveCharacter(x);
        }
    }
}
