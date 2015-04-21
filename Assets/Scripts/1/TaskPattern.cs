using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TaskPattern : MonoBehaviour
{
	public Text _count;
	public int count = 0;
	public static TaskPattern sphere;

	void Awake ()
	{
		sphere = this;
	}

	void Update ()
	{
		_count.text = count.ToString ();
	}
}