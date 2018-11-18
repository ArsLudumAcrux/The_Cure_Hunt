using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicaoScript : MonoBehaviour {

    Vector3 PosAtual;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SetPosition(Vector3 pos)
    {
        PosAtual = pos;
    }
}
