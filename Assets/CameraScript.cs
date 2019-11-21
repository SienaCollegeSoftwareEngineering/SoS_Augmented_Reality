/*
 //Place this script on a GameObject to switch between the main Camera and your own second Camera on the press of the "L" key
//Place a second Camera in your Scene and assign it as the "Camera Two" in the Inspector.

using UnityEngine;

public class CameraScript : MonoBehaviour
{
    static WebCamTexture backCam;


    void Start()
    {
        if (backCam == null)
            backCam = new WebCamTexture();

        GetComponent<Renderer>().material.mainTexture = backCam;

        if (!backCam.isPlaying)
            backCam.Play();
    }

    void Update()

    {

    }
}
*/
using ZXing;
using ZXing.QrCode;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    static WebCamTexture camTexture;
    public Rect screenRect;
    void Start()
    {
        screenRect = new Rect(0, 0, Screen.width, Screen.height);
        camTexture = new WebCamTexture();
        camTexture.requestedHeight = Screen.height;
        camTexture.requestedWidth = Screen.width;
        if (camTexture != null)
        {
            camTexture.Play();
        }
    }

    void OnGUI()
    {
        // drawing the camera on screen
        GUI.DrawTexture(screenRect, camTexture, ScaleMode.ScaleToFit);
        // do the reading — you might want to attempt to read less often than you draw on the screen for performance sake
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            // decode the current frame
            var result = barcodeReader.Decode(camTexture.GetPixels32(),
              camTexture.width, camTexture.height);
            if (result != null)
            {
                Debug.Log("DECODED TEXT FROM QR: " + result.Text);
            }
        }
        catch{ //(Exception ex) { Debug.LogWarning(ex.Message); }
    }
    }
}