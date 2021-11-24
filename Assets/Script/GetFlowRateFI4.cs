using UnityEngine;
using UnityEngine.UI;

public class GetFlowRateFI4 : MonoBehaviour
{
    Text text_timeSpend;
    float angleCV34;
    float angleCV32;
    void Start()
    {
        text_timeSpend = GetComponent<Text>();
    }
    double FullflowRate = 1.0d;
    void Update()
    {
//        angleCV34 = GetInspectorRotationValueMethod(GameObject.Find("valveCV34").transform);
//        angleCV32 = GetInspectorRotationValueMethod(GameObject.Find("valveCV32").transform);
        angleCV34 = GetFlowRateFI5.GetInspectorRotationValueMethod(GameObject.Find("valveCV34").transform);
        angleCV32 = GetFlowRateFI5.GetInspectorRotationValueMethod(GameObject.Find("valveCV32").transform);
        if (angleCV34 >= 90)
        {
            ValueStore.flowRateFI4 = FullflowRate * (angleCV34 - 90.0) / 177.0 - FullflowRate * (angleCV32 - 90.0) / 177.0;
            if (ValueStore.flowRateFI4 < 0)
            {
                ValueStore.flowRateFI4 = 0;
            }
            if (ValueStore.WaterLevelReactor > 35.0)
            {
                ValueStore.flowRateFI4 = 0;
            }
        }
        text_timeSpend.text = string.Format("FI4:{0:f2}(L/min)", ValueStore.flowRateFI4);
    }
}
