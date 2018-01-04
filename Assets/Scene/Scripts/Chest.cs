using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

	public GameObject Chesttop;
	bool Chest_Open;

	void Update() {
		if (Chest_Open == true) {
			Chesttop.transform.Rotate (Time.deltaTime, 0, 0);
		}
	}

	public void ChestOpen() {
		Chest_Open = true;
	}

}
