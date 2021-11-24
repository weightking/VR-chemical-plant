using UnityEngine;
using UnityEngine.UI;

public class GetFlowRateFI1 : MonoBehaviour
{
    Text text_timeSpend;
    double angleCV34;
    double angleCV32;
    void Start()
    {
        text_timeSpend = GetComponent<Text>();
    }
    void Update()
    {
        text_timeSpend.text = string.Format("FI1:{0:f2}(L/min)", ValueStore.flowRateFI4);
    }
}
