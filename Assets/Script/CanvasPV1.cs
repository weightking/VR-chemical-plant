using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasPV1 : MonoBehaviour {

    private Button BigPlus;
    private Button BigMinus;
    private Button SmallPlus;
    private Button SmallMinus;

    Text text_timeSpend;

    private void Awake()
    {
        text_timeSpend= transform.Find("Text").GetComponent<Text>();
        Init();
    }
    // Update is called once per frame
    void Update () {
        text_timeSpend.text = string.Format("{0:f1} Kg", ValueStore.weight);
    }

    private void Init()
    {
        BigPlus = transform.Find("BigPlus").GetComponent<Button>();
        BigPlus.onClick.AddListener(()=>
        {
            ValueStore.weight += 1.0f;
        }
            );
        BigMinus = transform.Find("BigMinus").GetComponent<Button>();
        BigMinus.onClick.AddListener(()=>
        {
            ValueStore.weight -= 1.0f;
        }
            );
        SmallPlus = transform.Find("SmallPlus").GetComponent<Button>();
        SmallPlus.onClick.AddListener(() =>
        {
            ValueStore.weight += 0.1f;
        }
            );
        SmallMinus = transform.Find("SmallMinus").GetComponent<Button>();
        SmallMinus.onClick.AddListener(() =>
        {
            ValueStore.weight -= 0.1f;
        }
            );
    }
}
