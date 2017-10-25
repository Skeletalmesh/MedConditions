/*
 * 
 *   UI Interaction event methods
 *   
 *   KC
 *   */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
///  Methods called when UI buttons, etc. are clicked. 
/// </summary>
public class UIEvents : MonoBehaviour
{

    public void RestartLevel()
    {
      
        SceneManager.UnloadScene(0);
        SceneManager.LoadScene(0);

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
