using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{ 
   public Camera cameraComponent;
    // Start is called before the first frame update
   public float zoomSize =0.1f;

    // Update is called once per frame
    void Update()
    {
        CameraSizeZoomInZoomOut();
        
    }
    void CameraSizeZoomInZoomOut()
    {
        //take E to zoom in and 
        if(Input.GetKey(KeyCode.E))
        {
            if (cameraComponent.orthographicSize<10)
            cameraComponent.orthographicSize+=zoomSize;
            
        }
        if(Input.GetKey(KeyCode.Q))
        {
            if (cameraComponent.orthographicSize>1)
              cameraComponent.orthographicSize-=zoomSize;
        }
    }
}
