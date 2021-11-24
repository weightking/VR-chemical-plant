using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlarmAcknowledge : MonoBehaviour {

    private Button AcknowledgeButton;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        AcknowledgeButton = transform.Find("Button").GetComponent<Button>();
        AcknowledgeButton.onClick.AddListener(() =>
        {
            ValueStore.WaterLevelReactorAlarm = true;
        }
        );
    }

}
