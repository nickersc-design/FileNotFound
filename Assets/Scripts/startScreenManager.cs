using UnityEngine;

public class startScreenManager : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private Transform cam;

    void Update()
    {
        cam.Rotate(0, speed * Time.deltaTime, 0);
    }
}
