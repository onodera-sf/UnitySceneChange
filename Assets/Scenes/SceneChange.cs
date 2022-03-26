using UnityEngine;
using UnityEngine.SceneManagement;  // 追加

public class SceneChange : MonoBehaviour
{
	/// <summary>ボタンをクリックしたときに呼ばれます。</summary>
	public void OnClick()
	{
		// 指定したシーンを読み込み他のシーンは削除します
		SceneManager.LoadScene("SampleScene2", LoadSceneMode.Single);
	}
}
