using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{
    private GameObject donut;
    private Camera mainCamera;
    [SerializeField] private float xdistance = 5f;
    [SerializeField] private float ydistance = 10f;
    [SerializeField] private float zdistance = -15.5f;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        donut = GameObject.Find("Donut Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerInfo = donut.transform.transform.position;
        mainCamera.transform.position = new Vector3(playerInfo.x + xdistance, playerInfo.y + ydistance, playerInfo.z + zdistance);
    }
}
