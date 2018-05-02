using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] a = { 3, 52, 34, 43, 24 };
        int i;
        for(i = 0; i < 5; i++)
        {
            Debug.Log(a[i]);
        }
        for (i = 4; i >= 0; i--)
        {
            Debug.Log(a[i]);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
