using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLight : MonoBehaviour
{
	public Vector3 center;
	public float speed;

	void Update ()
	{
		transform.RotateAround(center, Vector3.up, speed * Time.deltaTime);
	}
}
