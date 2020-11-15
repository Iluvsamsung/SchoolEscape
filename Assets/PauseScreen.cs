using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
public class PauseScreen : MonoBehaviour
{
	public bool IsPause;
	public GameObject PausePanel;
	public GameObject ButtonVisible;

    // Use this for initialization
    void Awake()
	{
		IsPause = false;
		ButtonVisible.SetActive(false);
		PausePanel.SetActive(false);
	}
	void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			OnPause();
		}
	}

	public void OnPause()
	{
		if (IsPause == false)
		{
			IsPause = true;
			PausePanel.SetActive(true);
			ButtonVisible.SetActive(true);
			Time.timeScale = 0;
		}
	    else if (IsPause == true)
		{
			IsPause = false;
			PausePanel.SetActive(false);
			ButtonVisible.SetActive(false);
			Time.timeScale = 1;
		}
	
	}

			
	
	

}
