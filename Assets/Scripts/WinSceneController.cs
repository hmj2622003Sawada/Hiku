using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCceneController : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene("WinScene");
	}
}
