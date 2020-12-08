using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateobject : MonoBehaviour
{
    [Tooltip("Speed of rotation of the object in z - axis")]
    [SerializeField]
    private float z_speed = 0f;
    /// <summary>
    /// Speed of rotation.
    /// </summary>
    public float Speed
    {
        get
        {
            return z_speed;
        }
        set
        {
            z_speed = value;
        }
    }
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, z_speed) * Time.deltaTime);
    }
}
