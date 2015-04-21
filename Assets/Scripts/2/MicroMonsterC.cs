using UnityEngine;
using System.Collections;

public class MicroMonsterC : MonoBehaviour
{
	Vector3? CheckPoint = null;
	int i = 0;
	Ray XRay;
	RaycastHit XrayHit;
	Input h;
	public GameObject Sphere;
	float timer;
	Vector3 v1;
	Vector3 v2;
	Vector3 dot;

	void Start ()
	{
		GameObject.Find ("micro_ghost").transform.SetX (Space.World, 5f);
		GameObject.Find ("micro_ghost").transform.SetY (Space.World, 1f);
		GameObject.Find ("micro_ghost").transform.SetZ (Space.World, 1f); 
		v1 = new Vector3 (0.5f, 0.5f, 0.5f);
		v2 = new Vector3 (1.5f, 1.5f, 1.5f);
		GameObject Point = (GameObject)Instantiate (Sphere, v1.Vector3point (v1, v2), Quaternion.identity);
		timer = 0;
	}
	
	void Update ()
	{
		GameObject.FindGameObjectWithTag ("Player").transform.position = Vector3.Lerp (GameObject.FindGameObjectWithTag ("Player").transform.position, dot, 0.1f);
		timer += Time.deltaTime;
		if (timer > 2) {
			dot = v1.Vector3point (v1, v2);

			timer = 0;

		}
		if (h.IfButtonDown ("a", "b")) {
			print ("True");
		} 
		if (Input.GetMouseButtonDown (0)) {
			CheckPoint = new Vector3 (Random.Range (1f, 19f), 0f, Random.Range (1f, 19f));
			XRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			i = 0;
		}
		if (CheckPoint.HasValue) {
			if (Physics.Raycast (XRay, out XrayHit, 100f)) {
				i++;
				XrayHit.transform.position = Vector3.Lerp (XrayHit.transform.position, CheckPoint.Value, i / 100f);
				if (i >= 100) {
					CheckPoint = null;
				}
			}
		}
	}
}
