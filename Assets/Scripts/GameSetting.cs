using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSetting : MonoBehaviour
{
    [Header("Текущая скорость")]
    [SerializeField] float speed = 75f;

    [Header("Интервал перед увеличением")]
    [SerializeField] private float interval = 10f;

    [Header("Интервал перед увеличением")]
    [SerializeField] private float speedUp = 0.01f;

    [Header("Время, прошедшее с начала")]
    private float elapsedTime = 0f;
    
    [Header("Скорость авто влево-вправо")]
    [SerializeField] private float moveSpeed = 25f;

    public float Speed { get { return speed; } set { speed = value; } }
    public bool IsGame { get; set; }
    public float MoveSpeed { get { return moveSpeed; } set { moveSpeed = value; } }

    [SerializeField] private GameObject grass;
    [SerializeField] private GameObject LiderBoardPanel;

        [SerializeField] private Text score;

    void Update()
    {
        if (IsGame)
        {
            UpdateSpeedOverTime();
        }
    }

    void UpdateSpeedOverTime()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= interval)
        {
            Time.timeScale += speedUp;
            print(Time.timeScale);
            elapsedTime = 0f;
        }
    }

    public void GrassOff()
    {
        grass.SetActive(true);
        LiderBoardPanel.SetActive(true);

        score.text = FindObjectOfType<UIManager>().Points.ToString();

    }



}
