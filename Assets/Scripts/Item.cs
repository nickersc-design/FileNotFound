using UnityEngine;

public class Item : MonoBehaviour
{
    public bool held;
    [SerializeField] private Behaviour[] disable;

    private void Update()
    {
        if (held)
        {
            foreach(Behaviour c in disable)
            {
                c.enabled = false;
            }
            if (GetComponent<Collider>() != null)
            {
                GetComponent<Collider>().enabled = false;
            }
            if (GetComponent<Rigidbody>() != null)
            {
                GetComponent<Rigidbody>().isKinematic = true;
            }
        }
        else
        {
            foreach (Behaviour c in disable)
            {
                c.enabled = true;
            }
            if (GetComponent<Collider>() != null)
            {
                GetComponent<Collider>().enabled = true;
            }
            if (GetComponent<Rigidbody>() != null)
            {
                GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }
}
