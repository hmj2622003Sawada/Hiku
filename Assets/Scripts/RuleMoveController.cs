using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class RuleMoveController : MonoBehaviour
{
	private void Update()
	{
		if(Keyboard.current.enterKey.wasPressedThisFrame)
		{
			SceneManager.LoadScene("SelectLevelScene");
		}
	}
}
