using UnityEngine;
using UnityEngine.UI;

public class GetWeightCV1 : MonoBehaviour
{
    Text text_timeSpend;

    void Start()
    {
        text_timeSpend = GetComponent<Text>();
    }
    void Update()
    {
        text_timeSpend.text = string.Format("WT:{0:f2}Kg", ValueStore.weight);
    }
}
