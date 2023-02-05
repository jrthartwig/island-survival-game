using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighthouseLight : MonoBehaviour
{
    Light lighthouseLight;

    // Start is called before the first frame update
    void Start()
    {
        lighthouseLight = gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        var current = lighthouseLight.transform.localRotation.x;
        //lighthouseLight.transform.localRotation = Quaternion.Euler(current + 50, 0, 0);
        lighthouseLight.transform.localEulerAngles = new Vector3(0, Time.time * 50, 0);

    }
}
