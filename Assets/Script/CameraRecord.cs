using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRecord : MonoBehaviour {

    public Camera camera;
    float positionX;
    float positionY;
    float positionZ;
    float RotationX;
    float RotationY;
    float RotationZ;
    // Use this for initialization
    void Start () {
        positionX = camera.transform.localPosition.x;
        positionY = camera.transform.localPosition.y;
        positionZ = camera.transform.localPosition.z;
        RotationX = camera.transform.localEulerAngles.x;
        RotationY = camera.transform.localEulerAngles.y;
        RotationZ = camera.transform.localEulerAngles.z;
    }
	
	// Update is called once per frame
	void Update () {
        ValueStore.DifferencePositionX = camera.transform.localPosition.x - positionX;
        ValueStore.DifferencePositionY = camera.transform.localPosition.y - positionY;
        ValueStore.DifferencePositionZ = camera.transform.localPosition.z - positionZ;
        ValueStore.DifferenceRotationX = camera.transform.localEulerAngles.x - RotationX;
        ValueStore.DifferenceRotationY = camera.transform.localEulerAngles.y - RotationY;
        ValueStore.DifferenceRotationZ = camera.transform.localEulerAngles.z - RotationZ;
    }
}
