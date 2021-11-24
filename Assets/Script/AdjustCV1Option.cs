using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustCV1Option : MonoBehaviour {

    int a;
    int b;
    private Button Hopper;
    private Button Auger;
    public GameObject m_UiPanel1;
    public GameObject m_UiPanel2;

    private void Awake()
    {
        m_UiPanel1.SetActive(false);
        m_UiPanel2.SetActive(false);
        Init();
    }
    private void Init()
    {
        Hopper = transform.Find("Hopper").GetComponent<Button>();
        Hopper.onClick.AddListener(() =>
        {
            a++;
            if (a % 2 != 0)
            {
                m_UiPanel1.SetActive(true);
            }
            if (a % 2 == 0)
            {
                m_UiPanel1.SetActive(false);
            }
        }
        );

        Auger = transform.Find("Auger").GetComponent<Button>();
        Auger.onClick.AddListener(() =>
        {
            b++;
            if (b % 2 != 0)
            {
                m_UiPanel2.SetActive(true);
            }
            if (b % 2 == 0)
            {
                m_UiPanel2.SetActive(false);
            }
        }
        );
    }
}
