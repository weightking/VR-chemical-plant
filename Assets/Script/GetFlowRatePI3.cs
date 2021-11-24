using UnityEngine;
using UnityEngine.UI;

public class GetFlowRatePI3 : MonoBehaviour
{
    Text text_timeSpend;
    void Start()
    {
        text_timeSpend = GetComponent<Text>();
    }
    double pressure = 0.0d;
    void Update()
    {
        text_timeSpend.text = string.Format("PI3:{0:f2} bar\n\nSpeed:{1:D2} %", pressure, ValueStore.pumpSpeed);
    }
}
