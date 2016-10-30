using UnityEngine;
using System.Collections;

public class CollectibleCaught : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Player")) {
				// Increase player score
			other.gameObject.GetComponent<Player>().incScore();
				// Remove itself
			this.gameObject.SetActive(false);
		}
	}
}
