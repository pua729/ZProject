using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
	public Camera camera;
	public Text nameText;
	public Button leftButton;
	public Button rightButton;

	public GameObject slideArea;

	[HideInInspector] private int _targetObjectIndex;
	[HideInInspector] private GameObject _targetObject;

	void Start()
	{
		leftButton.onClick.AddListener(OnClickLeftButton);
		rightButton.onClick.AddListener(OnClickRightButton);
		UpdateTargetObject();
	}

	void Update()
	{
#if DEBUG
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			OnClickRightButton();
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			OnClickLeftButton();
		}
#endif
	}

	private void UpdateTargetObject(int nextIndex = 0)
	{
		MeshRenderer[] objects = slideArea.GetComponentsInChildren<MeshRenderer>().Where(c => slideArea != c.gameObject).ToArray();
		if (0 <= nextIndex && nextIndex < objects.Length && objects.ElementAt(nextIndex))
		{
			_targetObjectIndex = nextIndex;
			_targetObject = objects[_targetObjectIndex].gameObject;
			slideArea.transform.position += new Vector3(-1 * _targetObject.transform.position.x, 0, 0);
			nameText.text = _targetObject.name;
		}
	}

	private void OnClickRightButton()
	{
		// 対象を左にシフト
		UpdateTargetObject(_targetObjectIndex + 1);
	}

	private void OnClickLeftButton()
	{
		// 対象を右にシフト
		UpdateTargetObject(_targetObjectIndex - 1);
	}
}
