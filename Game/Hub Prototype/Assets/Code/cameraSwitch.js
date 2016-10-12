#pragma strict

public var isthistopdown:boolean;
public var delayer:boolean;
public var cam1 : Camera;
public var cam2 : Camera;

function Start() 
{
	cam1.enabled = true;
	cam2.enabled = false;
}

function Update() 
{
if (Input.GetKeyDown(KeyCode.P))
	{
		cam1.enabled = !cam1.enabled;
		cam2.enabled = !cam2.enabled;
	}

if (cam1.enabled == true)
	{
		isthistopdown = false;
	}

if (cam2.enabled == true)
	{
		isthistopdown = true;
	}

if (isthistopdown == true)
	{
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
if (isthistopdown == false)
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
}






/*
function Start () 
{
	delayer = true;
}

function Update () 
{
	if ((Input.GetKeyDown ("space") && (isthistopdown == true)))
	{
		firstperson ();
		Debug.Log ("fps");
	}
	if ((Input.GetKeyDown ("space") && (isthistopdown == false)))
	{
		topdown ();
		Debug.Log ("not fps");
	}
	if (Input.GetKeyDown (KeyCode.Space))
	{
		Debug.Log ("Space was pressed once");
	}
}

function topdown()
{
	if (!isthistopdown)
	{
		fpscam.transform.position = topdowncam.transform.position;
		fpscam.transform.rotation = topdowncam.transform.rotation;
		isthistopdown = true;
	}
}

function firstperson()
{
	if (isthistopdown)
	{ 
		topdowncam.transform.position = fpscam.transform.position;
		topdowncam.transform.rotation = fpscam.transform.rotation;
		isthistopdown = false;
	}
}
|*/