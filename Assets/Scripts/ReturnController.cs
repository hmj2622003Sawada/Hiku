using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ReturnController : MonoBehaviour
{
	public int timer = 0;
	private void Start()
	{
		Application.targetFrameRate = 60;
	}
	private void Update()
	{
		timer++;
		if (timer == 120)
		{
			SceneManager.LoadScene("TitleScene");
		}
	}
}
