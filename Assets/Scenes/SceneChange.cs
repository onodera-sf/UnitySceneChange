using UnityEngine;
using UnityEngine.SceneManagement;  // �ǉ�

public class SceneChange : MonoBehaviour
{
	/// <summary>�{�^�����N���b�N�����Ƃ��ɌĂ΂�܂��B</summary>
	public void OnClick()
	{
		// �w�肵���V�[����ǂݍ��ݑ��̃V�[���͍폜���܂�
		SceneManager.LoadScene("SampleScene2", LoadSceneMode.Single);
	}
}
