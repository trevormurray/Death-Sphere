using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public float deathCounterLimit = 2;
    private float deathCounter;

    // Start is called before the first frame update
    void Start()
    {
        deathCounter = deathCounterLimit;
    }

    // Update is called once per frame
    void Update()
    {
        deathCounter -= Time.deltaTime;
        if (deathCounter <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
