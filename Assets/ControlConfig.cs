using UnityEngine;
using System.Collections;

public class ControlConfig : MonoBehaviour {

	bool isControllerConnected = false;
	public string Controller = "";
	public string PC_Move, PC_Rotate, PC_Item1, PC_Item2, PC_Item3, PC_Item4, PC_Inv, PC_Pause, PC_AttackUse, PC_Aim;
	public string Xbox_Move, Xbox_Rotate, Xbox_Item1, Xbox_Item2, Xbox_Item3, Xbox_Item4, Xbox_Inv, Xbox_Pause, Xbox_AttackUse, Xbox_Aim;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DetectController()
	{
		try {
			if (Input.GetJoystickNames() [0] != null)
			{
				isControllerConnected = true;
				IdentifyController();
			}
		}
		catch {
			isControllerConnected = false;
		}
	}

	void IdentifyController()
	{
		Controller = Input.GetJoystickNames () [0];
	}

	void SetDefaultValues()
	{
		if(!isControllerConnected)
		{
			PC_Move = "WASD";
			PC_Rotate = "Mouse";
			PC_Item1 = "1";
			PC_Item2 = "2";
			PC_Item3 = "3";
			PC_Item4 = "4";
			PC_Inv = "I";
			PC_Pause = "Escape";
			PC_AttackUse = "Left Mouse Button";
			PC_Aim = "Right Mouse Button";
		}
		else
		{
			PC_Move = "WASD";
			PC_Rotate = "Mouse";
			PC_Item1 = "1";
			PC_Item2 = "2";
			PC_Item3 = "3";
			PC_Item4 = "4";
			PC_Inv = "I";
			PC_Pause = "Escape";
			PC_AttackUse = "Left Mouse Button";
			PC_Aim = "Right Mouse Button";
			Xbox_Move = "Left Thumbstick";
			Xbox_Rotate = "Right Thumbstick";
			Xbox_Item1 = "D-Pad Up";
			Xbox_Item2 = "D-Pad Down";
			Xbox_Item3 = "D-Pad Left";
			Xbox_Item4 = "D-Pad Right";
			Xbox_Inv = "A Button";
			Xbox_Pause = "Start Button";
			Xbox_AttackUse = "Right Trigger";
			Xbox_Aim = "Left Trigger";
		}
	}
}
