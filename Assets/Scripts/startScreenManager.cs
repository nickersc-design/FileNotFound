using UnityEngine;

public class startScreenManager : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private Transform cam;
    [SerializeField] private int fps = 60;


    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = fps;
    }

    void Update()
    {
        cam.Rotate(0, speed * Time.deltaTime, 0);
    }
}
