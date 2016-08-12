using UnityEngine;
using System.Collections;

public class ViewManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("viewManager");
        var gameObj = (GameObject)Resources.Load("prefab/StarManager");
        Instantiate(gameObj);

        Camera camera = Camera.main;
        var vector = new Vector3(0, 0, 0);
        camera.transform.LookAt(vector);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
