using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackNum : MonoBehaviour
{
    private Text NumberText;
    int num = 3;
    void Start()
    {
        NumberText = GetComponent<Text>();
    }

    public void ChangeNum()
    {
        num--;
        NumberText.text = num.ToString();
    }
}
