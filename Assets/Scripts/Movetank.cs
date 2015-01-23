using UnityEngine;
using System.Collections;

public class Movetank : MonoBehaviour {
	public float rotationspeed = 1.5f;
	public float moveSpeed = 0.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey (KeyCode.UpArrow)) 
		{
			transform.Translate(Vector3.forward * moveSpeed);	
		}
	if (Input.GetKey (KeyCode.DownArrow)) 
		{
			transform.Translate(-Vector3.forward * moveSpeed);	
		}
	if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Rotate(-Vector3.up * rotationspeed);	
		}
	if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Rotate(Vector3.up * rotationspeed);	
		}
	}
}
