using UnityEngine;

public class Box : MonoBehaviour
{
    GameSetting GameSetting;

    void Awake()
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

    private void OnTriggerEnter(Collider other)
    {
        /// game over
        if (other.gameObject.CompareTag("Player"))
        {
            GameSetting.GrassOff();

            GameSetting.IsGame = false;
            Time.timeScale = 0;
        }
    }

    void Move()
    {
        transform.Translate(Vector3.back * GameSetting.Speed * Time.deltaTime);

        if (transform.position.z < 10) Destroy(gameObject,1);

    }

}
