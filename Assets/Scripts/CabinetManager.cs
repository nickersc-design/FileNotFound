using UnityEngine;

public class CabinetManager : MonoBehaviour
{
    public bool open;
    public bool locked;

    [SerializeField] private Transform drawer;
    [SerializeField] private Transform inLock;
    [SerializeField] private Transform outLock;
    [SerializeField] private float speed;

    void Update()
    {
        if (!locked)
        {
            if (open && drawer.position != outLock.position)
            {
                drawer.position = outLock.position;
            }
            else if (!open && drawer.position != inLock.position)
            {
                drawer.position = inLock.position;
            }
        } 
    }
}
