using UnityEngine;
using UnityEngine.UI;

public class HopperSpeed : MonoBehaviour
{

    Text text_timeSpend;

    void Start()
    {
        text_timeSpend = GetComponent<Text>();
    }
    void Update()
    {
        text_timeSpend.text = string.Format("CV1H:{0:f2}%", ValueStore.HopperSpeed);
    }
}
