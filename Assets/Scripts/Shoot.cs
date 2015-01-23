using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bulletPre;
	private GameObject turret;
	private GameObject nozzle;
	// Use this for initialization
	void Start () {
		Transform[] Transforms = GetComponentsInChildren<Transform> ();
		foreach (Transform t in Transforms) 
		{
			if(t.gameObject.name == "Turret")
			{
				turret = t.gameObject;
			}
			if (t.gameObject.name == "Nozzle")
			{
				nozzle = t.gameObject;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) 
		{
			Quaternion rotation = Quaternion.Euler(Vector3.up * turret.transform.rotation.eulerAngles.y);

			Instantiate(bulletPre, nozzle.transform.position, rotation);   
		}
	}
}
