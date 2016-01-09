using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DynamicMenu : MonoBehaviour {

	GameObject aGameObject;
	public Transform MainPanel;
	public GameObject Level1Item, Level2Items;
	public BArray[] buttons;

	void Start () {

//		aGameObject = GameObject.Instantiate (Level1Item) as GameObject;
//		aGameObject.transform.parent = MainPanel.transform;
//
//		aGameObject = GameObject.Instantiate (Level2Items) as GameObject;
//		aGameObject.transform.parent = MainPanel.GetChild(0).transform;

		init ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ReflectMenuHierarchy()
	{
		Debug.Log ("What is Happening!!");


	}

	void init()
	{
		for (int i = 0; i < buttons.Length; ++i) {
			aGameObject = GameObject.Instantiate (Level1Item) as GameObject;
			aGameObject.transform.parent = MainPanel.transform;
			aGameObject.name = "item"+i;
			aGameObject.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "item"+i;

			for(int j = 0; j<buttons[i].bArray.Length; ++j){
				aGameObject = GameObject.Instantiate (Level2Items) as GameObject;
				aGameObject.transform.parent = MainPanel.GetChild(i).transform;
			}
			MainPanel.GetChild(i).GetChild(0).GetComponent<Buttonx>().children = new GameObject[buttons[i].bArray.Length];
			Debug.Log(MainPanel.GetChild(i).GetChild(0).GetComponent<Buttonx>().children.Length);
			for(int j = 0; j<buttons[i].bArray.Length; ++j){
//				Debug.Log(MainPanel.GetChild(i).GetChild(0).GetComponent<Buttonx>().children[j]);
//				Debug.Log(MainPanel.GetChild(i).GetChild(j).gameObject);//.GetComponent<GameObject>());
				MainPanel.GetChild(i).GetChild(0).GetComponent<Buttonx>().children[j] = MainPanel.GetChild(i).GetChild(j+1).gameObject;

			}
		}
	}
}

