
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timetest : MonoBehaviour {

    private AudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource = this.GetComponent<AudioSource>();
    }
    // Update is called once per frame
	void Update () {
        ValueStore.WaterLevelReactor = ValueStore.WaterLevelReactor + ValueStore.flowRateFI4 * Time.deltaTime - ValueStore.flowRateFI3 * Time.deltaTime;
        print(ValueStore.WaterLevelReactor);
        if (ValueStore.WaterLevelReactor > 30.0 && Time.frameCount % 30 == 0)
            {
                Debug.Log("playsound");
                audioSource.Play();
        }
        if (ValueStore.WaterLevelReactor <= 30.0|| ValueStore.WaterLevelReactorAlarm)
        { 
                audioSource.Stop();
        }
    }
}
