using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseSceneController : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		SceneManager.LoadScene("LoseScene");
	}
}