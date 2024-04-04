using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Block : MonoBehaviour
{
	[SerializeField] int points = 100;
	[SerializeField] AudioSource audioSource;

	Rigidbody rb;
	bool destoyed = false;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if ((rb.velocity.magnitude > 2) || rb.angularVelocity.magnitude > 2)
		{
			audioSource.Play();
		}
	}

	private void OnTriggerStay(Collider other)
	{
		if (!destoyed && other.CompareTag("Kill") &&
			rb.velocity.magnitude == 0 &&
			rb.angularVelocity.magnitude == 0)
		{
			destoyed = true;
			Destroy(gameObject, 2);
		}
	}
}
