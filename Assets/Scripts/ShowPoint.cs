using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPoint : MonoBehaviour
{
    void Start()
    {
        transform.Rotate(0, 0, Random.Range(-20, 21));
        Destroy(gameObject,1);
    }

    void Update()
    {
        transform.Translate(0,2f*Time.deltaTime,0);
    }
}
