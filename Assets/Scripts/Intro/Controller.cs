using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Intro.ViewModels
{
	public class Controller : MonoBehaviour
	{
		public Button unitychanUiButton;
		public Button shaderTestUiButton;
		public Button textureTestUiButton;

		public void Start()
		{
			unitychanUiButton.onClick.AddListener(onClickUnitychanUiButton);
			shaderTestUiButton.onClick.AddListener(onClickShaderTestUiButton);
			textureTestUiButton.onClick.AddListener(onClickTextureTestUiButton);
		}

		public void onClickUnitychanUiButton()
		{
			SceneManager.LoadScene(Common.GamesScenes.Test.ToString());
		}

		public void onClickShaderTestUiButton()
		{
			SceneManager.LoadScene(Common.GamesScenes.ShaderTest.ToString());
		}

		public void onClickTextureTestUiButton()
		{
			SceneManager.LoadScene(Common.GamesScenes.TextureTest.ToString());
		}
	}
}
