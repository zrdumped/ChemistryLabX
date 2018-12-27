using UnityEngine;

public class WaterBeaker : MonoBehaviour
{
    Color waterColor;

    void Start()
    {
        var water = transform.Find("water").transform;
        waterColor = water.gameObject.GetComponent<MeshRenderer>().material.color;
    }

    public void ResetWaterColor()
    {
        var water = transform.Find("water").transform;
        water.gameObject.GetComponent<MeshRenderer>().material.color = waterColor;
    }
}
