using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaries : MonoBehaviour
{

    private Vector2 screenBounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, -screenBounds.x + 0.5f, screenBounds.x - 0.5f);
        viewPos.y = Mathf.Clamp(viewPos.y, -screenBounds.y + 0.5f, screenBounds.y - 0.5f);  
        transform.position = viewPos;
    }
}
