using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [SerializeField] private Text pointsText;
    [SerializeField] private GameObject ShowCoinText;
    [SerializeField] private Transform ShowPointsPlace;
    GameSetting GameSetting;

    [SerializeField] private AudioClip[] clips;
    private AudioSource audioSource;


    [SerializeField] private float mTime = 0.5f;
    private float cTime;

    private int points = 0;
    public int Points{ get { return points; } private set { } } 


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        GameSetting = FindObjectOfType<GameSetting>();

    }

    void Start()
    {
        Time.timeScale = 1;

    }

    void Update()
    {
        if (GameSetting.IsGame)
        {
            PointUp();
            UpdateUI();
        }

    }


    public void StartGame()
    {
        StartCoroutine(StartGames());
    }


    private IEnumerator StartGames()
    {
        audioSource.Play();
        yield return new WaitForSeconds(3);
        GameSetting. IsGame = true;
        audioSource.Stop();
        audioSource.clip = clips[Random.Range(0,3)];
        audioSource.Play();

    }

    public void CoinUp(int point)
    {
        points += point;

        GameObject showText = Instantiate(ShowCoinText, ShowPointsPlace.position, Quaternion.identity, ShowPointsPlace);
        showText.GetComponent<Text>().text = point.ToString();
    }

    private void PointUp()
    {
        cTime += Time.deltaTime;

        if (cTime >= mTime)
        {
            points++;

            cTime = 0;
        }
    }

    public void UpdateUI()
    {
        pointsText.text = $"Очки: {points.ToString()}";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
