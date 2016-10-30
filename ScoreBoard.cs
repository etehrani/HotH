using UnityEngine;
using System.Collections;

    // To give to collectible
public class ScoreBoard : MonoBehaviour {
    public Transform target;
    float offsetY = 40;
    float sizeX = 100;
    float sizeY= 40;

    void OnGUI() {
        float recentScore = target.gameObject.GetComponent<Player>().getScore();
        GUI.Box(new Rect(Screen.width / 2 - sizeX / 2, offsetY, sizeX, sizeY), "Score: " + recentScore);
    }
	// Use this for initialization
	void Start () {
        OnGUI();
	}
	
	// Update is called once per frame
	void Update () {
        OnGui();
	}
}
