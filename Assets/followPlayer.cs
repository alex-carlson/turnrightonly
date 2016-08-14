using UnityEngine;
using System.Collections;

public class followPlayer : MonoBehaviour {

    public Transform target;
    float lerpSpeed = 5f;

	// Use this for initialization
	void Start () {
        if (target == null)
            target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.transform.position + (target.transform.forward * -5f) + (target.transform.up * 2f);
        transform.LookAt(target);
	}
}
