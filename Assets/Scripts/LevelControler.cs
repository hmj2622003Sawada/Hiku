using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class LevelControler : MonoBehaviour
{ 
	public static int  SelectLevel = 0;
	private void Update()
	{
		if (Keyboard.current.digit0Key.wasPressedThisFrame)
		{												   
			SelectLevel = 0;
			SceneManager.LoadScene("GameScene");
		}
		if (Keyboard.current.digit1Key.wasPressedThisFrame)
		{
			SelectLevel = 1;
			SceneManager.LoadScene("GameScene");
		}
		if (Keyboard.current.digit2Key.wasPressedThisFrame)
		{
			SelectLevel = 2;
			SceneManager.LoadScene("GameScene");
		}
		if (Keyboard.current.digit3Key.wasPressedThisFrame)
		{
			SelectLevel = 3;
			SceneManager.LoadScene("GameScene");
		}
		if (Keyboard.current.digit4Key.wasPressedThisFrame)
		{
			SelectLevel = 4;
			SceneManager.LoadScene("GameScene");
		}
		if (Keyboard.current.digit5Key.wasPressedThisFrame)
		{
			SelectLevel = 5;
			SceneManager.LoadScene("GameScene");
		}
		if (Keyboard.current.digit6Key.wasPressedThisFrame)
		{												   
			SelectLevel = 6;
			SceneManager.LoadScene("GameScene");
		}
		if (Keyboard.current.digit7Key.wasPressedThisFrame)
		{
			SelectLevel = 7;
			SceneManager.LoadScene("GameScene");
		}
		if (Keyboard.current.digit8Key.wasPressedThisFrame)
		{
			SelectLevel = 8;
			SceneManager.LoadScene("GameScene");
		}
		if (Keyboard.current.digit9Key.wasPressedThisFrame)
		{
			SelectLevel = 9;
			SceneManager.LoadScene("GameScene");
		}
	}
}
