using UnityEngine;

public class Coin : MonoBehaviour
{
    GameSetting GameSetting;
    UIManager UIManager;

    void Awake()
    {
        GameSetting = FindObjectOfType<GameSetting>();
        UIManager = FindObjectOfType<UIManager>();
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
        if (other.gameObject.CompareTag("Player"))
        {
            UIManager.CoinUp(100);
            Destroy(gameObject);
        }
    }

    void Move()
    {
        transform.Translate(Vector3.back * GameSetting.Speed * Time.deltaTime);

        if(transform.position.z<10) Destroy(gameObject,1);
    }
}
