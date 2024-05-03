using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsqueletoMove : MonoBehaviour
{
    [SerializeField] private float Speed;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 8f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rig.velocity = Vector2.right * Speed * Time.fixedDeltaTime;
    }
}
