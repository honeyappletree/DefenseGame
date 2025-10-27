using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Awake()
    {
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;
        float screenHeight = ((float)Screen.width / Screen.height) / ((float)9 / 16);
        float screenWidth = 1f / screenHeight;

        if(screenHeight < 1)
        {
            rect.height = screenHeight;
            rect.y = (1f - screenHeight) / 2f;
        }
        else
        {
            rect.width = screenWidth;
            rect.x = (1f - screenWidth) / 2f;
        }
        camera.rect = rect;
    }

    void OnPreCull() => GL.Clear(true, true, Color.black);
}
