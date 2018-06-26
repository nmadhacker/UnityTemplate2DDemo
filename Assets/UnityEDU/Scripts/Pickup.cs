using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
	private int coinCount;

	public Text coinText;
	public AudioClip coinSound;



	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.CompareTag ("coin")) {
			AudioSource.PlayClipAtPoint(coinSound, other.transform.position);
			coinCount ++;
			coinText.text = coinCount.ToString();
			Destroy(other.gameObject);
		}
	}
}