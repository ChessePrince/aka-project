using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordPickup : MonoBehaviour
{
    GameObject goWeapon;
    GameObject goPlayerWeapon;
    public GameObject goWeaponForPickUp;

    void Awake()
    {
        goWeapon = GameObject.FindGameObjectWithTag("WeaponUI");
        goPlayerWeapon = GameObject.FindGameObjectWithTag("PlayerWeapon");
    }
    private void Start()
    {
        goWeapon.SetActive(false);
        goPlayerWeapon.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerCollider"))
        {
            goWeapon.SetActive(true);
            goPlayerWeapon.SetActive(true);
            goWeaponForPickUp.SetActive(false);        
        }
    }
}
