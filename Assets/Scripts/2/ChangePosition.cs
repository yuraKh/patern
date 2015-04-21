using UnityEngine;
using System.Collections;

public static class ChangePosition
{
	#region TransformSet

	public static void SetX (this Transform TrX, float x)
	{
		TrX.position = new Vector3 (x, TrX.position.y, TrX.position.z);
	}

	public static void SetY (this Transform TrY, float y)
	{
		TrY.position = new Vector3 (TrY.position.x, y, TrY.position.z);
	}

	public static void SetZ (this Transform TrZ, float z)
	{
		TrZ.position = new Vector3 (TrZ.position.x, TrZ.position.y, z);
	}

	public static void SetX (this Transform TrX, Space CoordinateSystem, float x)
	{
		if (CoordinateSystem == Space.World) {
			TrX.position = new Vector3 (x, TrX.position.y, TrX.position.z);
		} else {
			TrX.localPosition = new Vector3 (x, TrX.localPosition.y, TrX.localPosition.z);
		}
	}

	public static void SetY (this Transform TrY, Space CoordinateSystem, float y)
	{
		if (CoordinateSystem == Space.World) {
			TrY.position = new Vector3 (TrY.position.x, y, TrY.position.z);
		} else {
			TrY.localPosition = new Vector3 (TrY.localPosition.x, y, TrY.localPosition.z);
		}
	}

	public static void SetZ (this Transform TrZ, Space CoordinateSystem, float z)
	{
		if (CoordinateSystem == Space.World) {
			TrZ.position = new Vector3 (TrZ.position.x, TrZ.position.y, z);
		} else {
			TrZ.localPosition = new Vector3 (TrZ.localPosition.x, TrZ.localPosition.y, z);

		}
	}
	#endregion

	#region Input
	public static bool IfButtonDown (this Input I, KeyCode one, KeyCode two)
	{
		bool t = false;
		if (Input.GetKeyDown (one) && Input.GetKeyDown (two)) {
			t = true;
		}
		return t;
	}
	public static bool IfButtonDown (this Input I, string one, string two)
	{
		bool t = false;
		if (Input.GetKeyDown (one) && Input.GetKeyDown (two)) {
			t = true;
		}
		return t;
	}
	#endregion

	#region Vector3point
	public static Vector3 Vector3point (this Vector3 one, Vector3 POne, Vector3 PTwo)
	{
		return new Vector3 (Random.Range (POne.x, PTwo.x), Random.Range (POne.y, PTwo.y), Random.Range (POne.z, PTwo.z));
	}
	public static Vector3 Vector3point (this Vector3 one, Vector3 POne, float x, float y, float z)
	{
		return new Vector3 (Random.Range (POne.x, x), Random.Range (POne.y, y), Random.Range (POne.z, z));

	}

	#endregion
}
