using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHud : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        // Background color doesn't seem to do anything here...
        GUI.color = Color.yellow;
        GUI.backgroundColor = Color.blue;
        GUI.Box(new Rect(10, 10, 150, 20), "DIFFICULTY: " + SpawnManager.difficultyLevel);
        GUI.Box(new Rect(10, 40, 150, 20), "KILLS: " + PlayerController.kills);
        GUI.Box(new Rect(10, (Screen.height - 80), 150, 20), "POWER: " + PlayerController.shotCount);
        GUI.Box(new Rect(10, (Screen.height - 40), 150, 20), "DEFENSE: " + PlayerController.defensePoints);
    }
}
