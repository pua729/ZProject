using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
	public Camera camera;
	public Light light;
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
		// ライトの一秒当たりの回転角度
		float Angle = 30f;
	
		// ライトを回転
		light.transform.RotateAround(Vector3.zero, Vector3.up ,Angle * Time.deltaTime);
	}

	private void UpdateTargetObject(int nextIndex = 0)
	{
		Transform[] objects = slideArea.GetComponentsInChildren<Transform>().Where(c => slideArea != c.gameObject).ToArray();
		if (0 <= nextIndex && nextIndex < objects.Length && objects.ElementAt(nextIndex))
		{
			_targetObjectIndex = nextIndex;
			_targetObject = objects[_targetObjectIndex].gameObject;
			slideArea.transform.position += new Vector3(-1 * _targetObject.transform.position.x, 0, 0);
		}
		nameText.text = _targetObject.name;
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
