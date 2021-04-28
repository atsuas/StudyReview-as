using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float x;
    float z;
    public float moveSpeed = 2f;

    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(x, 0, z) * moveSpeed;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "smallgun")
    //    {
    //        //Playerの子としてアタッチしてあるガンを持つようの空オブジェクトを取得
    //        GameObject handgrip = transform.FindChild("BulletRuncher").gameObject;
    //        //プロジェクトに作ったResourcesフォルダ内にある"SmallGun"オブジェクトをロードして、上記の空オブジェクトの位置に置く
    //        GameObject weapon = Instantiate(Resources.Load("Prefabs/SmallGun"), handgrip.transform.position, handgrip.transform.rotation) as GameObject;
    //        weapon.transform.Rotate(0, 180, 0); //必要に応じてガンの位置を調整
    //        weapon.transform.Translate(0, -1, 0);　//必要に応じてガンの位置を調整
    //        weapon.transform.parent = handgrip.transform; //プレイヤー側の空オブジェクトの子にガンを設定

    //        bulletruncher.GetWeapon();
    //    }
    //}
}
