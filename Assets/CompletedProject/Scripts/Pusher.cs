using UnityEngine;

public class Pusher : MonoBehaviour
{
    Rigidbody _rigidbody;
    Vector3 origin;

    void Start ()
    {
        _rigidbody = GetComponent<Rigidbody> ();
        origin = _rigidbody.position;
    }
		
    void Update ()
    {
        Vector3 offset = new Vector3 (0, 0, Mathf.Sin(Time.time));
        _rigidbody.MovePosition (origin + offset);
    }
}
