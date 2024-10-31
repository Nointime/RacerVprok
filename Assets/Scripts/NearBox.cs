using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearBox : MonoBehaviour
{

    UIManager UIManager;

    private void Awake()
    {
        UIManager = FindObjectOfType<UIManager>();

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            UIManager.CoinUp(Random.Range(100, 201));
        }
    }
}
