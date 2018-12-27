using UnityEngine;

public class CubeBeaker : MonoBehaviour
{
    Vector3 cubeStartPosition;
    Quaternion cubeStartRotation;
    
	void Start ()
    {
        var cube = transform.Find("cube").transform;
        cubeStartPosition = cube.localPosition;
        cubeStartRotation = cube.rotation;
	}
	
    public void ResetCubeTransform()
    {
        var cube = transform.Find("cube").transform;
        cube.localPosition = cubeStartPosition;
        cube.localRotation = cubeStartRotation;
    }
}
