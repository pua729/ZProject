using Test.ViewModels;
using UnityEngine;

namespace Test
{
	public class Controller : MonoBehaviour
	{
		public MainViewModel mainPanel;
		public MenuViewModel menuPanel;

		public GameObject playablePrefab;

		[HideInInspector] 
		public Animator animator;

		void Start()
		{
			animator = Instantiate(playablePrefab, new Vector3(250, 0, 250), Quaternion.identity).GetComponent<Animator>();
		}

		void Update()
		{
			if (Input.GetKey("up"))
			{
				Debug.Log("go front");
				transform.position += transform.forward * 0.01f;
				animator.SetBool("is_running", true);
				//animator.SetTrigger("Run");
			} else {
				Debug.Log("stop");
				animator.SetBool("is_running", false);
			}
			if (Input.GetKey("right"))
			{
				Debug.Log("turn right");
				transform.Rotate(0, 10, 0);
			}
			if (Input.GetKey("left"))
				Debug.Log("turn left");
			{
				transform.Rotate(0, -10, 0);
			}
		}
	}
}	
