using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score;
    PlayerMove playerMoverScript;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        playerMoverScript = player.GetComponent<PlayerMove>();
        scoreText.gameObject.SetActive(true);
        DisplayUpdatedScore();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayUpdatedScore();
    }

    private void DisplayUpdatedScore()
    {
        score = playerMoverScript.itemsCollected;
        scoreText.SetText("Golden Mushrooms: " + score);
    }
}
