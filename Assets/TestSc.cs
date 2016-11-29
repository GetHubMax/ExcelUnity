using UnityEngine;
using System.Collections;

public class TestSc : MonoBehaviour {
	//may need setter methods
	public int IntTest;
	public double DoubleTest;
	public string StringTest;
	public string n;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetInt(int v){
		IntTest = v;
	}

	public void SetDouble(double v){
		DoubleTest = v;
	}

	public void SetString(string v){
		StringTest= v;
	}


	public void Name(string v){
		n = v;
	}
}
