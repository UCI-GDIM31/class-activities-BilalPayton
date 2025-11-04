using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed;
    private Transform cat;

    public void EnableChase(Transform player)
    {
        enabled = true;
        cat = player;
    }

    public void DisableChase()
    {
        enabled = false;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, cat.position, speed * Time.deltaTime);
    }

    private void Start()
    {
        EnableChase(cat);
    }
}
