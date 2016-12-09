﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MessageBoard : MonoBehaviour {
	public Text[] log;
	int index;
	void Start()
	{
		index = 0;
	}

	void Update()
	{
		AddLog();
	}

	void AddLog()
	{
		if (MenuButtonClick.buttonPressed)
		{
			log[index].text = MenuButtonClick.button.name + "()";
			index++;
		}
	}
}
