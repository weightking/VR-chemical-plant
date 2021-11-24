using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class CavasShow : MonoBehaviour {

    public GameObject m_UiPanel;
    int a = 0;
    bool pointerTouch;
	// Use this for initialization
    private void Awake()
    {
        GameObject.Find("ControllerRight").GetComponent<VRTK_ControllerEvents>().TouchpadReleased += PumpFilter1_TouchpadReleased;
        GameObject.Find("ControllerLeft").GetComponent<VRTK_ControllerEvents>().TouchpadReleased += PumpFilter1_TouchpadReleased;
        GameObject.Find("ControllerRight").GetComponent<VRTK_ControllerEvents>().TriggerPressed += PumpFilter1_TriggerPressed;
        GameObject.Find("ControllerLeft").GetComponent<VRTK_ControllerEvents>().TriggerPressed += PumpFilter1_TriggerPressed;
        m_UiPanel.SetActive(false);
    }

    private void PumpFilter1_TriggerPressed(object sender, ControllerInteractionEventArgs e)
    {
        if (pointerTouch == true)
        {
            a++;
            show();
        }
    }

    private void PumpFilter1_TouchpadReleased(object sender, ControllerInteractionEventArgs e)
    {
        pointerTouch = false;
    }


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        pointerTouch = true;
    }
    private void show()
    {
        if (a % 2 != 0)
        {
            m_UiPanel.SetActive(true);
        }
        if (a % 2 == 0)
        {
            m_UiPanel.SetActive(false);
        }
    }
}
