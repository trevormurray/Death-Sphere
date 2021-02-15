using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseEffect : MonoBehaviour
{
    public float timeToLive = 1.2f;
    private Light thisLight;
    private float thisCounter;
    public float multiplier = 2;
    private bool multSwitch = true;

    // Start is called before the first frame update
    void Start()
    {
        thisLight = GetComponent<Light>();
        thisCounter = timeToLive;
    }

    // Update is called once per frame
    void Update()
    {
        thisCounter -= Time.deltaTime;
        if (thisCounter <= (timeToLive / 2) && multSwitch)
        {
            multiplier = multiplier * -1;
            multSwitch = !multSwitch;
        }
        if (thisCounter <= 0)
        {
            Destroy(gameObject);
        }
        Debug.Log("LIGHT EFFECT:" + (Time.deltaTime * multiplier));
        thisLight.intensity += 1 * multiplier;
    }
}
