using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
	int timer = 0;
	bool Flag = true;


	private void Start()
	{
		Application.targetFrameRate = 60;
	}

	private void Update()
	{
		// プレイヤーの移動
		if (Keyboard.current.spaceKey.wasPressedThisFrame)
		{
			transform.Translate(-0.1f, 0, 0); // 左に1動かす
		}

		// 敵の移動
		if (Flag == true)
		{
			timer++;
			if (timer % 60  == 0)
			{
				transform.Translate(0.1f, 0, 0); // 右に移動
			}
		}

		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("ゴール");
		Flag = false;
	}
}
