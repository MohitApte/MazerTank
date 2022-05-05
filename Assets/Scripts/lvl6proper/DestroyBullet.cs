using UnityEngine;
using System.Collections;

namespace level6
{
	public class DestroyBullet : MonoBehaviour {
		public GameObject bullet;

		void OnTriggerEnter (Collider other)
		{
			Destroy (bullet);
		}

	
	}

}
