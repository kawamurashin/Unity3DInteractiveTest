using UnityEngine;
using System.Collections;

public class StarManager : MonoBehaviour {
    float targetRotation = 0;
    float rotation = 0;
    Star[] starList;
    // Use this for initialization
    void Start () {
        GameObject obj;
        Star star;
        //

        var n = 10;
        starList = new Star[n];
        for (var i=0;i<n;i++)
        {
            obj = (GameObject)Resources.Load("prefab/Star");
            star = Instantiate(obj).GetComponent<Star>();
            
            var theta = 2 * Mathf.PI * (float)(i) / (float)(n);
            star.x = 5 * Mathf.Cos(theta + rotation);
            star.z = 5 * Mathf.Sin(theta + rotation);
            star.name = "star+" + i;
            starList[i] = star;
        }
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {
                GameObject obj = hit.collider.gameObject;
                Star star = (Star)(obj.transform.parent).GetComponent<Star>();
                Debug.Log(star.name);
                var theta = Mathf.Atan2(star.z, star.x);
                targetRotation = rotation - theta - Mathf.PI*0.5f;
                if(targetRotation - rotation > Mathf.PI)
                {
                    targetRotation -= 2*Mathf.PI;
                }
                else if(targetRotation - rotation < -1 * Mathf.PI)
                {
                    targetRotation += 2*Mathf.PI;
                }
                
            }
        }
        var dr = targetRotation - rotation;
        rotation += dr * 0.03f;
        int n = starList.Length;
        for (var i = 0; i < n; i++)
        {

            Star star = starList[i];
            var theta = 2 * Mathf.PI * (float)(i) / (float)(n);
            star.x = 5 * Mathf.Cos(theta + rotation);
            star.z = 5 * Mathf.Sin(theta + rotation);
        }
    }
}
