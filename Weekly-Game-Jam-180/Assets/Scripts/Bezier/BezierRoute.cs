using UnityEngine;

public class BezierRoute : MonoBehaviour
{
    [SerializeField] private Transform[] controlPoints;

	private void OnDrawGizmos()
	{
		for (float t = 0; t <= 1; t += 0.05f) {
			Vector2 pos = Mathf.Pow(1 - t, 3) * controlPoints[0].position +
				3 * Mathf.Pow(1 - t, 2) * t * controlPoints[1].position +
				3 * (1 - t) * Mathf.Pow(t, 2) * controlPoints[2].position +
				Mathf.Pow(t, 3) * controlPoints[3].position;

			Gizmos.DrawSphere(pos, 0.25f);
		}

		Gizmos.DrawLine(controlPoints[0].position, controlPoints[1].position);
		Gizmos.DrawLine(controlPoints[2].position, controlPoints[3].position);
	}
}
