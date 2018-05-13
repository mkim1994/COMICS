﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_manager : MonoBehaviour {

    public GameObject infoMenu;
    public GameObject characterMenu;

    public GameObject profileButton;
	// Use this for initialization
	void Start () {
        infoMenu.SetActive(false);
        characterMenu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if(characterMenu.activeSelf){

            profileButton.GetComponent<Animator>().SetTrigger("pagechecked");
        }
	}

    public void Restart(){
        globalstate.Instance.reload();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void InfoMenu(){
        characterMenu.SetActive(false);
        if(infoMenu.activeSelf){
            infoMenu.SetActive(false);
        } else{
            infoMenu.SetActive(true);
        }
    }
    public void CharMenu()
    {
        infoMenu.SetActive(false);
        if (characterMenu.activeSelf)
        {

            //profileButton.GetComponent<Animator>().SetTrigger("");
            characterMenu.SetActive(false);
        }
        else
        {

            profileButton.GetComponent<Animator>().SetTrigger("pagechecked");
            characterMenu.SetActive(true);
        }
    }
}
