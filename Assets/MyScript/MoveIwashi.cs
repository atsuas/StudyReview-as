using UnityEngine;
using System;

public class MoveIwashi : MonoBehaviour
{
    [SerializeField]
    float speed = 0.3f;

    [SerializeField]
    float rotationSpeed = 0.01f;

    [SerializeField]
    float rotation_Interval = 3;

    Rigidbody iwasirigid;

    void Start()
    {
        iwasirigid = GetComponent<Rigidbody>();

    }


    void Update()
    {
        //前に進む
        iwasirigid.velocity = this.gameObject.transform.forward * speed;

        //外積で元に戻す　X軸方向
        Vector3 left = this.gameObject.transform.TransformVector(Vector3.left);
        Vector3 hori_left = new Vector3(left.x, 0, left.z).normalized;
        iwasirigid.AddTorque(Vector3.Cross(left, hori_left) * 4, ForceMode.Force);

        //外積で元に戻す　Z軸方向
        Vector3 forward = this.gameObject.transform.TransformVector(Vector3.forward);
        Vector3 hori_forward = new Vector3(forward.x, 0, forward.z).normalized;
        iwasirigid.AddTorque(Vector3.Cross(forward, hori_forward) * 4, ForceMode.Force);

    }
}