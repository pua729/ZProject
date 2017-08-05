using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Intro.ViewModels
{
	public class Controller : MonoBehaviour
	{
		public Button unitychanUiButton;
		public Button shaderTestUiButton;

		public void Start()
		{
			unitychanUiButton.onClick.AddListener(onClickUnitychanUiButton);
			shaderTestUiButton.onClick.AddListener(onClickShaderTestUiButton);
		}

		public void onClickUnitychanUiButton()
		{
			SceneManager.LoadScene(Common.GamesScenes.Test.ToString());
		}

		public void onClickShaderTestUiButton()
		{
			SceneManager.LoadScene(Common.GamesScenes.ShaderTest.ToString());
		}
	}
}
