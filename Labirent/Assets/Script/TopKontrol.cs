using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text zaman, can;
    private Rigidbody rg;
    float zamansayaci = 10;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        zamansayaci-=Time.deltaTime;
        zaman.text = zamansayaci + "";
    }

    void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 kuvvet = new Vector3(dikey, 0, dikey);
        rg.AddForce(kuvvet*3f); 
    }

    void OnCollisionEnter(Collision cls)
    {
        string objIsmi = cls.gameObject.name;
        if (objIsmi.Equals("Bitis"))
        {
            print("Oyun Tamamlandý");
        }
    }
}
