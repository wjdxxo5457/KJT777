﻿using UnityEngine;
using System.Collections;

public class WallCtrl : MonoBehaviour {

    public GameObject sparkEffect;

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "BULLET")
        {

            GameObject spark = (GameObject)Instantiate(sparkEffect, coll.transform.position, Quaternion.identity);
            Destroy(coll.gameObject);
            Destroy(spark, spark.GetComponent<ParticleSystem>().duration + 0.2f);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
