using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Intro.ViewModels
{
	public class Controller : MonoBehaviour
	{
		public Button unitychanUiButton;

		public void Start()
		{
			unitychanUiButton.onClick.AddListener(onClickUnitychanUiButton);
		}

		public void onClickUnitychanUiButton()
		{
			SceneManager.LoadScene(Common.GamesScenes.Test.ToString());
		}
	}
}
