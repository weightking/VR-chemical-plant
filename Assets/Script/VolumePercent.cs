using UnityEngine;
using UnityEngine.UI;

public class VolumePercent : MonoBehaviour
{
    Text text_timeSpend;
    double angleCV86;
    double angleV91;
    double percentage;
    void Start()
    {
        text_timeSpend = GetComponent<Text>();
    }
    double FullflowRate = 1.0d;
    void Update()
    {
        angleCV86 = GameObject.Find("valveCV86").transform.eulerAngles.z;
        angleV91 = GameObject.Find("valveV91").transform.eulerAngles.z;
        if (angleV91 >= 90)
        {
            ValueStore.flowRateFI3 = FullflowRate * (angleV91 - 90.0) / 177.0 - FullflowRate * (angleCV86 - 90.0) / 177.0;
        }
        if (ValueStore.flowRateFI3 < 0)
        {
            ValueStore.flowRateFI3 = 0;
        }
        if (ValueStore.WaterLevelProductPercentage >= 100)
        {
            ValueStore.WaterLevelProductPercentage = 100;
            ValueStore.flowRateFI3 = 0;
        }
        else
        {
            ValueStore.WaterLevelProduct = ValueStore.WaterLevelProduct + ValueStore.flowRateFI3 * Time.deltaTime;
            ValueStore.WaterLevelProductPercentage = ValueStore.WaterLevelProduct / 50.0 * 100;
        }
        text_timeSpend.text = string.Format("{0:f2}%", ValueStore.WaterLevelProductPercentage);
    }
}
