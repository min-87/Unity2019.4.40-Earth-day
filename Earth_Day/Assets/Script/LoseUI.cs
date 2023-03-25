using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseUI : MonoBehaviour
{
    [SerializeField] private Canvas endGameCanvas;

    private void Awake()
    {
        Time.timeScale = 1f;
    }

    private void Start()
    {
        endGameCanvas.enabled = false;
    }

    public void EndGame()
    {
        Time.timeScale = 0f;
        FindObjectOfType<CamRay>().gameObject.SetActive(false);
        endGameCanvas.enabled = true;
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(0);
    }
}
