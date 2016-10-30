using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int getScore() {
		return mScore;
	}
	public int getLives() {
		return mLives;
	}
	public void incScore() {
		mScore += 100;
	}
	public void decLives() {
		mLives--;
	}
	private int mScore;
	private int mLives;
		// Use this for initialization
	void Start () {
		mScore = 0;
		mLives = 5;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
