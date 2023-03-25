﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CamRay : MonoBehaviour
{
    private Camera myCam;
    private TMP_Text scoreText;
    private int score;

    private void Awake()
    {
        myCam = Camera.main;
        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit = new RaycastHit(); 
            Ray ray = myCam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                GameObject temp = hit.collider.gameObject;
                if(temp.CompareTag("trash"))
                {
                    Destroy(temp);
                    score++;
                    scoreText.text = $"Score: {score}";
                }
            }
        }
    }
}
