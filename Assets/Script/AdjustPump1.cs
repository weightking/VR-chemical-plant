using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustPump1 : MonoBehaviour {

    private Button Plus;
    private Button Minus;

    Text text_timeSpend;

    private void Awake()
    {
        text_timeSpend = transform.Find("Text").GetComponent<Text>();
        Init();
    }

    private void Update()
    {
        text_timeSpend.text = string.Format("{0:D2} %", ValueStore.pumpSpeed);
    }

    private void Init()
    {
        Plus = transform.Find("ButtonPlus").GetComponent<Button>();
        Plus.onClick.AddListener(() =>
        {
            ValueStore.pumpSpeed += 5;
        }
        );
        Minus = transform.Find("ButtonMinus").GetComponent<Button>();
        Minus.onClick.AddListener(() =>
        {
            ValueStore.pumpSpeed -= 5;
        }
        );
    }
}
