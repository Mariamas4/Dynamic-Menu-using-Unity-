using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Buttonx : MonoBehaviour {

	public GameObject[] children;
	bool parent, cascaded;

	void Start () {
	
		if (children.Length > 0)
			parent = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonClicked()
	{
		Debug.Log("xxxxxx");

		if (parent) {
			if (cascaded)
				expand ();
			else 
				cascade ();

			cascaded = !cascaded;
		}
	}

	void expand()
	{
		for (int i = 0; i <  children.Length; ++i)
			children [i].SetActive (true);

	}

	void cascade()
	{
		for (int i = 0; i <  children.Length; ++i)
			children [i].GetComponent<Buttonx> ().deactivate ();
	}

	public void deactivate()
	{
		if (parent)
			for (int i = 0; i <  children.Length; ++i)
				children [i].SetActive (false);
		gameObject.SetActive (false);

	}
//	public IEnumerator openList()
//	{
//		yield return 0;
//	}
}





