using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.UI;//注意这个不能少
using UnityEngine.SceneManagement;

public class Computer : MonoBehaviour {

    bool handtouch;
    private void Awake()
    {
        GameObject.Find("ControllerRight").GetComponent<VRTK_ControllerEvents>().TriggerPressed += InputStore_TriggerPressed;
        GameObject.Find("ControllerLeft").GetComponent<VRTK_ControllerEvents>().TriggerPressed += InputStore_TriggerPressed;
    }

    private void InputStore_TriggerPressed(object sender, ControllerInteractionEventArgs e)
    {
        GoToFlowChart();
        ValueStore.GhostDifferencePositionX = ValueStore.DifferencePositionX;
        ValueStore.GhostDifferencePositionY = ValueStore.DifferencePositionY;
        ValueStore.GhostDifferencePositionZ = ValueStore.DifferencePositionZ;
        ValueStore.GhostDifferenceRotationX = ValueStore.DifferenceRotationX;
        ValueStore.GhostDifferenceRotationY = ValueStore.DifferenceRotationY;
        ValueStore.GhostDifferenceRotationZ = ValueStore.DifferenceRotationZ;
    }
    private void OnTriggerEnter(Collider other)
    {
        handtouch = true;
    }
    private void OnTriggerExit(Collider other)
    {
        handtouch = false;
    }
    private void GoToFlowChart()
    {
        if (handtouch==true)
        {
            SceneManager.LoadScene("flowChart");
        }
    }
}
