using UnityEngine;
using System.Collections;

public class GateHandlerLeft : MonoBehaviour {

    private Animator _animator = null;

    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider collider)
    {
        _animator.SetBool("IsOpen", true);
    }

    void OnTriggerExit(Collider collider)
    {
       // _animator.SetBool("IsOpen", false);
    }
}
