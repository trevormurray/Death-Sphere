using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScrolling : MonoBehaviour
{
    public float xSpeed = 0.5f;
    public float ySpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float xOffset = Time.time * xSpeed;
        float yOffset = Time.time * ySpeed;
        //renderer.material.mainTextureOffset = new Vector2(xOffset, yOffset);
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(xOffset, yOffset);
    }
}
