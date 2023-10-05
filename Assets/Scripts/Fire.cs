using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject sphere;
    public ParticleSystem FireFire;
    private float sphereStartedPoint = 0;
    private Vector3 sphereScale;

    public bool fireActive = true;

    public float fireAccount = 5000;


    // Start is called before the first frame update
    void Start()
    {
        //SetFireState(fireActive);
        FireFire.Play();

    }

    // Update is called once per frame
    void Update()
    {
        // clickOn();
    }


    // clean

    public void SetFireState(bool active)
    {
        if (active)
        {
            FireFire.Play();

        } else
        {
            FireFire.Stop();

        }
    }

    public void SetDebitFire(float debit)
    {
        fireAccount -= debit;

        if (fireAccount == 0)
        {
            FireFire.Stop();
        }
    }
}
