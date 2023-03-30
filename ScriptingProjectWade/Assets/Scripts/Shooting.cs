using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;

    private Inventory inventory;

    private void Awake()
    {
        inventory = GetComponent<Inventory>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space) && inventory.myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation);
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
        }
    }
}
