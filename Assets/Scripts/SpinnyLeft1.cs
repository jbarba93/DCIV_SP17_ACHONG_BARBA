using UnityEngine;
using System.Collections;

public class SpinnyLeft1 : MonoBehaviour
{


    // Use this for initialization

    void OnTriggerStay()
    {
        // Rotate the object around its local X axis at 1 degree per second
        Debug.Log("Stay");
        transform.Rotate(Vector3.up * Time.deltaTime * 40);
    }

    void OnTriggerExit()
    {
        // Rotate the object around its local X axis at 1 degree per second
        //transform.Rotate(Vector3.left * Time.deltaTime * 150);
    }

}