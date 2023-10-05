using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extincteur : MonoBehaviour
{
    public Collider myColid;
    public ParticleSystem myFire;
    public ParticleSystem myWater;
    public bool waterState = false;
    public int debit;
    // Start is called before the first frame update
    void Start()
    {

        setWaterState(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        //OnTriggerEnter(myColid);
        OnTriggerStay(myColid);
        clickOn();
        
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Enter !");
        /*Fire fire = other.GetComponent<Fire>();

        if (fire.fireAccount != 0) {
            fire.SetDebitFire(1);
        } else
        {
            fire.SetFireState(false);
            setWaterState(false);
        }*/
        
        //myFire.gameObject.SetActive(false);


    }

    [System.Obsolete]
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay !");
        Fire fire = other.GetComponent<Fire>();
        ParticleSystem p = fire.GetComponent<ParticleSystem>();


        if (fire.fireAccount > 0)
        {
            Debug.Log(fire.fireAccount);
            Debug.Log(p.maxParticles);
            fire.SetDebitFire(debit);

        } else
        {
            p.Stop();
            setWaterState(false);

        }


    }


    public void clickOn()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Activate Extincteur");
            setWaterState(true);
        }
    }


    public void setWaterState(bool state)
    {
        waterState = state;
        if (state)
        {
            myWater.Play();

        } else
        {
            myWater.Stop();
        }
    }

    public void setDebitExtincteur()
    {
        myWater.maxParticles += debit;
    }
}
