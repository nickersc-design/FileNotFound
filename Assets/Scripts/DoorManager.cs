using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public bool open;
    public bool locked;

    [SerializeField] private Transform door;
    [SerializeField] private Transform inLock;
    [SerializeField] private Transform outLock;

    void Update()
    {
        if (!locked)
        {
            if (open && door.position != outLock.position)
            {
                door.position = outLock.position;
                door.rotation = outLock.rotation;
            }
            else if (!open && door.position != inLock.position)
            {
                door.position = inLock.position;
                door.rotation = inLock.rotation;
            }
        }
    }
}