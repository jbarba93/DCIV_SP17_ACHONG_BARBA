using UnityEngine;
using System.Collections;

public class hand : MonoBehaviour {



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
        transform.Rotate(Vector3.down * Time.deltaTime * 20);

    }
}
