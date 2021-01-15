using UnityEngine;

public class CameraInit : MonoBehaviour
{
    private Camera mainCamera;
    private float nextTime = 1f;
    private float timer = 0f;
    private bool isInitialized = false;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (timer > nextTime && !isInitialized)
        {
            GetComponent<Camera>().fieldOfView = mainCamera.fieldOfView;
            GetComponent<Camera>().farClipPlane = mainCamera.farClipPlane;
            isInitialized = true;
        }
        else timer += Time.deltaTime;
    }
}
