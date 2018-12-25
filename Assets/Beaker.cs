using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beaker : MonoBehaviour {

    Vector3 cubeStartPosition;
    Quaternion cubeStartRotation;
    
	void Start ()
    {
        var cube = transform.Find("Cube").transform;
        cubeStartPosition = cube.localPosition;
        cubeStartRotation = cube.localRotation;
	}
	
    public void ResetCubeTransform()
    {
        var cube = transform.Find("Cube").transform;
        cube.localPosition = cubeStartPosition;
        cube.localRotation = cubeStartRotation;
    }
}
