using UnityEngine;
using UnityEngine.UI;

public class AugerSpeed : MonoBehaviour
{

    Text text_timeSpend;

    void Start()
    {
        text_timeSpend = GetComponent<Text>();
    }
    void Update()
    {
        text_timeSpend.text = string.Format("CV1A:{0:f2}%", ValueStore.AugerSpeed);
    }
}
