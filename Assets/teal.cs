using UnityEngine;
using System.Collections;

public class teal : MonoBehaviour {


    Renderer r;

    // Use this for initialization
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(Vector3.right * Time.deltaTime * 20);

        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(Vector3.up * Time.deltaTime * 7);
    }

    void OnTriggerEnter()
    {
        Debug.Log("Enter");
        r.material.color = new Color(0, 92, 0);
    }

    void OnTriggerExit()
    {
        r.material.color = new Color(100, 125, 210);
    }

}