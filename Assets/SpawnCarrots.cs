using UnityEngine;
using System.Collections;

public class SpawnCarrots : MonoBehaviour {
    public int carrots;
    public GameObject carrot;

	// Use this for initialization
	void Start () {
	    for (int i = 0; i < carrots; i++)
        {
            GameObject newblock = (GameObject)Instantiate(carrot, new Vector3(0,0,0), Quaternion.Euler(0, 90 * (i % 2), 0));
            newblock.transform.Translate(Random.value * 5, 0, Random.value * 5);
        }
	}
	
	// Update is called once per frame
	void Update () { }
}
