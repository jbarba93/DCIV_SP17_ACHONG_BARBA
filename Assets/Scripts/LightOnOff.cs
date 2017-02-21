using UnityEngine;
using System.Collections;

public class LightOnOff : MonoBehaviour {
    public Light myLight;
    // Use this for initialization
    void Start()
    {
        myLight.intensity = 0;
    }

    void OnTriggerEnter()
    {
        //Light.enabled = true;     
        myLight.intensity = 1;   
    }

    void OnTriggerExit()
    {
        // Light.enabled = false;
        myLight.intensity = 0;
    }
    // Update is called once per frame
    void Update () {
	
	}
}
