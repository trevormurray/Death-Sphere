using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    private Color textColour;
    private int midScreen;

    // Start is called before the first frame update
    void Start()
    {
        textColour = Color.white;
        midScreen = Screen.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SoundController.PlaySound();
            textColour = Color.black;
            PlayerController.kills = 0;
            PlayerController.defensePoints = PlayerController.maxDefenseStatic;
            SceneManager.LoadScene("GameScene");
        }
    }

    private void OnGUI()
    {
        GUI.color = textColour;
        GUI.Label(new Rect(midScreen - 250, 180, 500, 500), "GAME OVER");
        GUI.Label(new Rect(midScreen - 250, 240, 300, 100), "TOTAL KILLS: " + PlayerController.kills);
        GUI.Label(new Rect(midScreen - 250, 280, 300, 100), "Click LEFT MOUSE to try again.");
    }
}
