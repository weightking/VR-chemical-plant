using UnityEngine;
using UnityEngine.UI;

public class GetFlowRatePI2 : MonoBehaviour
{
    Text text_timeSpend;
    void Start()
    {
        text_timeSpend = GetComponent<Text>();
    }
    double angleCV86;
    void Update()
    {
        angleCV86 = GameObject.Find("valveCV86").transform.eulerAngles.z;
        ValueStore.pressure=1.0* (267-angleCV86) / 177.0;
        text_timeSpend.text = string.Format("PI2:{0:f2} bar\n\nSpeed:{1:D2} %", ValueStore.pressure, ValueStore.pumpSpeed2);
    }
}
