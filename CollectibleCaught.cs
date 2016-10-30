using UnityEngine;
using System.Collections;

public class CollectibleCaught : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Player")) {
			Rigidbody otherRB = other.gameObject.GetComponent<Player>().incScore();
			this.gameObject.SetActive(false);
		}
	}
}