using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {
	public bool toContinue = true;
	private int ammo = 100;
	private string[] strings;
	// Use this for initialization
	void Start () {
		
		strings = new string[5];
		strings[0] = "My";
		strings[1] = "name";
		strings[2] = "is";
		strings[3] = "john";
		strings[4] = "doe";
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//while loop
		if(Input.GetKeyDown(KeyCode.P)){
			while(ammo > 0){
				Debug.Log(ammo);
				ammo--;
				
			}
			
		}
		//for loop
		if(Input.GetKeyDown(KeyCode.R)){
			for(int i = 0; i <100; i++){
				Debug.Log (i);
				
			}
			
		}
		
		//for each loop
		if(Input.GetKeyDown(KeyCode.O)){
			foreach(string item in strings){
				Debug.Log(item);
			}
		}

		if(Input.GetKeyDown(KeyCode.L)){
			do{
				Debug.Log("I printed this");
			}while(toContinue==true);
				

		}
		
		
		
		
	}
}
