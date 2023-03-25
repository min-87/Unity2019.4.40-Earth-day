using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private int maxCountLife;
    private TMP_Text lifeText;
    private int currentCountLife;

    private void Start()
    {
        lifeText = GameObject.Find("LifeText").GetComponent<TMP_Text>();
        currentCountLife = maxCountLife;
        lifeText.text = $"Life: {currentCountLife}";
    }

    public void RemoveLife()
    {
        currentCountLife--;

        if(currentCountLife == 0)
            FindObjectOfType<LoseUI>().EndGame();

        lifeText.text = $"Life: {currentCountLife}";
    }
}
