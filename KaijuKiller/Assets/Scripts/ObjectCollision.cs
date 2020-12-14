﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ObjectCollision : MonoBehaviour
{
    [SerializeField]
    private GameObject deathScreen;

    [SerializeField]
    private Button restartButton;

    [SerializeField]
    private Button quitButton; 

    CanvasGroup restartButtonCanvasGroup;
    CanvasGroup deathScreenCanvasGroup;
    CanvasGroup quitButtonCanvasGroup;

    [SerializeField]
    TextMeshProUGUI scoreText;

    [SerializeField]
    SpawnManager spawnManager;
    void Start()
    {
        deathScreenCanvasGroup = deathScreen.GetComponent<CanvasGroup>();
        restartButtonCanvasGroup = restartButton.GetComponent<CanvasGroup>();
        quitButtonCanvasGroup = quitButton.GetComponent<CanvasGroup>();


        quitButton.interactable = false;
        restartButton.interactable = false;
        deathScreenCanvasGroup.alpha = 0;
        restartButtonCanvasGroup.alpha = 0;
        quitButtonCanvasGroup.alpha = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle" || other.tag == "Enemy")
        {
            Time.timeScale = 0;
            deathScreenCanvasGroup.alpha = 1;
            restartButtonCanvasGroup.alpha = 1;
            quitButtonCanvasGroup.alpha = 1;
            quitButton.interactable = true;
            restartButton.interactable = true;

        }
        if (other.tag == "Road")
        {
            spawnManager.SpawnTriggerEntered();
        }

        if(other.tag == "PickUp")
        {
            Debug.Log("HitPickup");
            
        }

        

    }
}
