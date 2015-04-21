using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountP : MonoBehaviour
{
	public Text box;
	int r;
	float time;
	GameObject[] mass;
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		time += Time.deltaTime;
		if (time > 2f) {
			r = Random.Range (-5, 5);
			TaskPattern.sphere.count += r;
			time = 0;
			box.text = r.ToString ();
		}
	}
}