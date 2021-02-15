using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{

    private Color textColour;
    public GameObject blackout1;
    public GameObject blackout2;

    // Start is called before the first frame update
    void Start()
    {
        textColour = Color.white;    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SoundController.PlaySound();
            textColour = Color.black;
            Instantiate(blackout1);
            Instantiate(blackout2);
            SceneManager.LoadScene("GameScene");
        }
    }

    private void OnGUI()
    {
        GUI.color = textColour;
        GUI.Label(new Rect(100, 100, 500, 500), "DEATH SPHERE");
        GUI.Label(new Rect(200, 280, 500, 100), "Destroy as many invaders as possible before they overrun your defenses!");
        GUI.Label(new Rect(200, 340, 500, 100), "A + D to Move, LEFT MOUSE to fire.");
        GUI.Label(new Rect(200, 380, 500, 100), "Click LEFT MOUSE to begin.");
    }        
}
