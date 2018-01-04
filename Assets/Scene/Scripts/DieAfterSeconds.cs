using UnityEngine;
using System.Collections;

public class DieAfterSeconds : MonoBehaviour {
    IEnumerator Start () {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
	}
}
