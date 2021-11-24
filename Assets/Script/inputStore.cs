using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using VRTK;
using System.IO;

public class inputStore : MonoBehaviour {

    public GameObject m_UiPanel;
    int a = 0;
    int b = 0;
    bool handtouch;
    float yRotation;
    // Use this for initialization
    private void Awake () {
        GameObject.Find("ControllerRight").GetComponent<VRTK_ControllerEvents>().TriggerPressed += InputStore_TriggerPressed;
        GameObject.Find("ControllerLeft").GetComponent<VRTK_ControllerEvents>().TriggerPressed += InputStore_TriggerPressed;
        m_UiPanel.SetActive(false);
    }

    private void InputStore_TriggerPressed(object sender, ControllerInteractionEventArgs e)
    {
        a++;
        m_UiPanel.transform.eulerAngles=new Vector3(0.0f,GameObject.Find("ControllerRight").transform.eulerAngles.y,0.0f);
        CavasShow(a);
    }

    // Update is called once per frame
    void Update () {
 
	}
    private void OnTriggerEnter(Collider other)
    {
        handtouch = true;
    }
    private void OnTriggerExit(Collider other)
    {
        handtouch = false;
    }
    private void CavasShow(int a)
    {
        if (a % 2 != 0&&handtouch==true)
        {
            m_UiPanel.SetActive(true);
        }
        if (a % 2 == 0 && handtouch == true)
        {
            m_UiPanel.SetActive(false);
        }
    }
}
