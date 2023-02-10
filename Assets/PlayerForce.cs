using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerForce : MonoBehaviour
{
    public Rigidbody2D armleft;
    public Rigidbody2D armright;
    public Rigidbody2D legleft;
    public Rigidbody2D legright;
    public Rigidbody2D body;
    
    public AudioSource mysource;
    public AudioClip jumpClip;
    Rigidbody2D mainBody;
    public float power = 2f;
    // Start is called before the first frame update
    void Start()
    {
        mainBody = GetComponent<Rigidbody2D>();
        mysource.PlayOneShot(jumpClip);
        mysource.clip = jumpClip;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            armleft.AddForce(transform.right*-power, ForceMode2D.Impulse);
            mysource.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            armright.AddForce(transform.right*power, ForceMode2D.Impulse);
            mysource.Play();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            legleft.AddForce(transform.right*power, ForceMode2D.Impulse);
            mysource.Play();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            legright.AddForce(transform.right*-power, ForceMode2D.Impulse);
            mysource.Play();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(transform.up*5*power, ForceMode2D.Impulse);
            mysource.Play();
        }
        /*
        if (Input.GetKey(KeyCode.W))
        {
            mainBody.velocity = new Vector3(0, power, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            mainBody.velocity = new Vector3(0, -power, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            mainBody.velocity = new Vector3(-power, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            mainBody.velocity = new Vector3(power, 0, 0);
        }*/
    }
}
