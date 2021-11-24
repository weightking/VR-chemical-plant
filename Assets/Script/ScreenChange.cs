using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;//注意这个不能少
using UnityEngine.SceneManagement;

public class ScreenChange : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame

    public void OnClick()
    {
        SceneManager.LoadScene("flowChart");//切换到场景Scene_2
        ValueStore.GhostDifferencePositionX = ValueStore.DifferencePositionX;
        ValueStore.GhostDifferencePositionY = ValueStore.DifferencePositionY;
        ValueStore.GhostDifferencePositionZ = ValueStore.DifferencePositionZ;
        ValueStore.GhostDifferenceRotationX = ValueStore.DifferenceRotationX;
        ValueStore.GhostDifferenceRotationY = ValueStore.DifferenceRotationY;
        ValueStore.GhostDifferenceRotationZ = ValueStore.DifferenceRotationZ;
}

    void Update()
    {

    }
}
