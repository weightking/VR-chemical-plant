using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    float positionX = ValueStore.GhostDifferencePositionX;
    float positionY = ValueStore.GhostDifferencePositionY;
    float positionZ = ValueStore.GhostDifferencePositionZ;
    float RotationX = ValueStore.GhostDifferenceRotationX;
    float RotationY = ValueStore.GhostDifferenceRotationY;
    float RotationZ = ValueStore.GhostDifferenceRotationZ;

    public Camera camera;
    // Use this for initialization
    void Start () {
        camera.transform.Translate(new Vector3(positionX, positionY, positionZ));
        camera.transform.Rotate(RotationX, RotationY, RotationZ);
    }
	
	// Update is called once per frame
	void Update () {

    }
}
