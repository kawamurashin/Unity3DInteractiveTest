using UnityEngine;
using System.Collections;

public class MovieClip : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public float x
    {
        get
        {

            return this.transform.position.x;
        }

        set
        {
            var vector = this.transform.position;
            vector.x = value;
            this.transform.position = vector;
        }
    }
    public float y
    {
        get
        {

            return this.transform.position.y;
        }

        set
        {
            var vector = this.transform.position;
            vector.y = value;
            this.transform.position = vector;
        }
    }
    public float z
    {
        get
        {

            return this.transform.position.z;
        }

        set
        {
            var vector = this.transform.position;
            vector.z = value;
            this.transform.position = vector;
        }
    }
    public Vector3 xyz
    {
        get
        {

            return this.transform.position;
        }

        set
        {
            this.transform.position = value;
        }
    }

}
