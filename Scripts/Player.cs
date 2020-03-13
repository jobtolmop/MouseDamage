using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private Color deathColor;

    public int Health { get => health; }

    public Action<float, float> OnDamage;

    private void Start()
    {
        
    }

    private void OnMouseDown()
    {
        health -= 10;
        OnDamage(1f, 3f);
        
        if (health <= 0)
        {
            health = 0;
            gameObject.GetComponent<Renderer>().material.color = deathColor;
        }
    }
}
