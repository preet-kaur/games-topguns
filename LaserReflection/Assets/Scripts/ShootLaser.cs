 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
    public Material material;

    private LaserBeam beam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        beam = new LaserBeam(gameObject.transform.position, gameObject.transform.right, material);
    }
}
