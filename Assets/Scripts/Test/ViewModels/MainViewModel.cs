using UnityEngine;
using UnityEngine.UI;

namespace Test.ViewModels
{
	public class MainViewModel : MonoBehaviour
	{
		public Controller controller;
		public Button attackButton;
		public Button menuButton;

		public void Start()
		{
			attackButton.onClick.AddListener(onClickAttackButton);
			menuButton.onClick.AddListener(onClickMenuButton);
		}

		public void onClickAttackButton()
		{
			Debug.Log("attack");
		}

		public void onClickMenuButton()
		{
			Debug.Log("menu");
		}
	}
}
