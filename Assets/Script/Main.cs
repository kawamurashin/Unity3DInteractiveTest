using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var gameObj = (GameObject)Resources.Load("prefab/ViewManager");
        Instantiate(gameObj);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
