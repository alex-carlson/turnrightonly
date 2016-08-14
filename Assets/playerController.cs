using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

    public float speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            transform.Rotate(Vector3.up * 90);
        }
	}

    void FixedUpdate()
    {
        transform.position = transform.position + (transform.forward * speed * Time.deltaTime);
    }
}
