using UnityEngine;
using System.Collections;

public class SlideLeft : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    float m_distanceTraveled = 0f;

    void OnTriggerStay()
    {
        if (m_distanceTraveled < 5f)
        {
            Vector3 oldPosition = transform.position;
            transform.Translate(1 * Time.deltaTime, 0, 0);
            m_distanceTraveled += Vector3.Distance(oldPosition, transform.position);
        }
    }

    void OnTriggerExit()
    {
        if (m_distanceTraveled > 0f)
        {
            Vector3 oldPosition = transform.position;
            transform.Translate(-1 * Time.deltaTime, 0, 0);
            m_distanceTraveled += Vector3.Distance(oldPosition, transform.position);
        }
    }
}
