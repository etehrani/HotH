using UnityEngine;
using System.Collections;

public class CollectibleCaught : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Player")) {
				// Increase player score
			Rigidbody otherRB = other.gameObject.GetComponent<Player>().incScore();
				// Remove itself
			this.gameObject.SetActive(false);
		}
	}
}
